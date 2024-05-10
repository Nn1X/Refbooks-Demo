
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetAllV023
{
    public class GetAllV023QueryHandler : IRequestHandler<GetAllV023Query, V023[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV023QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V023[]> Handle(GetAllV023Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V023.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V023));
                }

                return result;
            }
        }
    }
}
