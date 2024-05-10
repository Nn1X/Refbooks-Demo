using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetRelevantF002ByCode;

public class GetRelevantF002ByCodeQueryHandler : IRequestHandler<GetRelevantF002ByCodeQuery, F002>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetRelevantF002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F002> Handle(GetRelevantF002ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entity = await context.F002.Where(x => x.DateBegin <= request.Date
                                                       && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                       && x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                throw new NotFoundException(nameof(F002), request.Code, request.Date);
            }

            return entity;
        }
    }
}