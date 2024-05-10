
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetAllV037
{
    public class GetAllV037QueryHandler : IRequestHandler<GetAllV037Query, V037[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV037QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V037[]> Handle(GetAllV037Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V037.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V037));
                }

                return result;
            }
        }
    }
}
