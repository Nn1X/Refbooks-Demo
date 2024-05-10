
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetAllN009
{
    public class GetAllN009QueryHandler : IRequestHandler<GetAllN009Query, N009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N009[]> Handle(GetAllN009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N009.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N009));
                }

                return result;
            }
        }
    }
}
