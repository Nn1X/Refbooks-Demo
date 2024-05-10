
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetAllN011
{
    public class GetAllN011QueryHandler : IRequestHandler<GetAllN011Query, N011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN011QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N011[]> Handle(GetAllN011Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N011.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N011));
                }

                return result;
            }
        }
    }
}
