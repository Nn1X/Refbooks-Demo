using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetRelevantF006ByCode;

public class GetRelevantF006ByCodeQueryHandler : IRequestHandler<GetRelevantF006ByCodeQuery, F006>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetRelevantF006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F006> Handle(GetRelevantF006ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entity = await context.F006.Where(x => x.DateBegin <= request.Date
                                                       && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                       && x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                throw new NotFoundException(nameof(F006), request.Code, request.Date);
            }

            return entity;
        }
    }
}