using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetRelevantF007ByCode;

public class GetRelevantF007ByCodeQueryHandler : IRequestHandler<GetRelevantF007ByCodeQuery, F007>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetRelevantF007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F007> Handle(GetRelevantF007ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entity = await context.F007.Where(x => x.DateBegin <= request.Date
                                                       && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                       && x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                throw new NotFoundException(nameof(F007), request.Code, request.Date);
            }

            return entity;
        }
    }
}