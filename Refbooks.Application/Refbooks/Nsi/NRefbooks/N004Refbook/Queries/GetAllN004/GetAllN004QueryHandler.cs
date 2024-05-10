
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetAllN004
{
    public class GetAllN004QueryHandler : IRequestHandler<GetAllN004Query, N004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN004QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N004[]> Handle(GetAllN004Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N004.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N004));
                }

                return result;
            }
        }
    }
}
