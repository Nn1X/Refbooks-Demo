using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetF006ByCode;

public class GetF006ByCodeQueryHandler : IRequestHandler<GetF006ByCodeQuery, F006[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetF006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F006[]> Handle(GetF006ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entities = await context.F006.Where(x => x.Code == request.Code)
                .ToArrayAsync(cancellationToken);

            if (!entities.Any())
            {
                throw new NotFoundException(nameof(F006), request.Code);
            }

            return entities;
        }
    }
}