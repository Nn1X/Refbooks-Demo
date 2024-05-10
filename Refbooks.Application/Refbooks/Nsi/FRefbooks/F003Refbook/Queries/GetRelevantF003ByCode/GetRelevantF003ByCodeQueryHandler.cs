using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetRelevantF003ByCode;

public class GetRelevantF003ByCodeQueryHandler : IRequestHandler<GetRelevantF003ByCodeQuery, F003>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetRelevantF003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F003> Handle(GetRelevantF003ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entity = await context.F003.Where(x => x.DateBegin <= request.Date
                                                       && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                       && x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                throw new NotFoundException(nameof(F003), request.Code, request.Date);
            }

            return entity;
        }
    }
}