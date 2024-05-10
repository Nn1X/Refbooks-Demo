
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetAllN007
{
    public class GetAllN007QueryHandler : IRequestHandler<GetAllN007Query, N007[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN007QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N007[]> Handle(GetAllN007Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N007.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N007));
                }

                return result;
            }
        }
    }
}
