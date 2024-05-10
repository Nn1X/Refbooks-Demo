
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetAllN014
{
    public class GetAllN014QueryHandler : IRequestHandler<GetAllN014Query, N014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N014[]> Handle(GetAllN014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N014.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N014));
                }

                return result;
            }
        }
    }
}
