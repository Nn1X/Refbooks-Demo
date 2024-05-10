
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetAllV027
{
    public class GetAllV027QueryHandler : IRequestHandler<GetAllV027Query, V027[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV027QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V027[]> Handle(GetAllV027Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V027.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V027));
                }

                return result;
            }
        }
    }
}
