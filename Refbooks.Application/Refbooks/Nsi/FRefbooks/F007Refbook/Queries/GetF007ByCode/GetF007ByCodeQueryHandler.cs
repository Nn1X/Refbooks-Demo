using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetF007ByCode;

public class GetF007ByCodeQueryHandler : IRequestHandler<GetF007ByCodeQuery, F007[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetF007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }


    public async Task<F007[]> Handle(GetF007ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entities = await context.F007.Where(x => x.Code == request.Code)
                .ToArrayAsync(cancellationToken);

            if (!entities.Any())
            {
                throw new NotFoundException(nameof(F007), request.Code);
            }

            return entities;
        }
    }
}