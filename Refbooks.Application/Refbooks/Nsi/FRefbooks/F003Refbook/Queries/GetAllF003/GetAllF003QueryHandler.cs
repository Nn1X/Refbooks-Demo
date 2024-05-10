using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetAllF003;

public class GetAllF003QueryHandler : IRequestHandler<GetAllF003Query, F003[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllF003QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F003[]> Handle(GetAllF003Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F003.ToArrayAsync(cancellationToken);
            if (!result.Any())
            {
                throw new NotFoundException(nameof(F003));
            }

            return result;
        }
    }
}