
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetAllN021
{
    public class GetAllN021QueryHandler : IRequestHandler<GetAllN021Query, N021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N021[]> Handle(GetAllN021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N021.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N021));
                }

                return result;
            }
        }
    }
}
