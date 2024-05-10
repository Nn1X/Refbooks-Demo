using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetAllF007;

public class GetAllF007QueryHandler : IRequestHandler<GetAllF007Query, F007[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllF007QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F007[]> Handle(GetAllF007Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F007.ToArrayAsync(cancellationToken);

            if (!result.Any())
            {
                throw new NotFoundException(nameof(F007));
            }

            return result;
        }
    }
}