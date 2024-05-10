using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetAllF002;

public class GetAllF002QueryHandler : IRequestHandler<GetAllF002Query, F002[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllF002QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F002[]> Handle(GetAllF002Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F002.ToArrayAsync(cancellationToken);
            if (!result.Any())
            {
                throw new NotFoundException(nameof(F002));
            }

            return result;
        }
    }
}