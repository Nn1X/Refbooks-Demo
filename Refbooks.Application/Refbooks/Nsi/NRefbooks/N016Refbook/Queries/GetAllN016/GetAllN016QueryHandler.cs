
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetAllN016
{
    public class GetAllN016QueryHandler : IRequestHandler<GetAllN016Query, N016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN016QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N016[]> Handle(GetAllN016Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N016.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N016));
                }

                return result;
            }
        }
    }
}
