
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetAllN020
{
    public class GetAllN020QueryHandler : IRequestHandler<GetAllN020Query, N020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN020QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N020[]> Handle(GetAllN020Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N020.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N020));
                }

                return result;
            }
        }
    }
}
