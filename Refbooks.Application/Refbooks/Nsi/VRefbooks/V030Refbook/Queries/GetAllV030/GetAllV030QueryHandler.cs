
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetAllV030
{
    public class GetAllV030QueryHandler : IRequestHandler<GetAllV030Query, V030[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV030QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V030[]> Handle(GetAllV030Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V030.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V030));
                }

                return result;
            }
        }
    }
}
