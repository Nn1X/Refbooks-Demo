
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetAllV010
{
    public class GetAllV010QueryHandler : IRequestHandler<GetAllV010Query, V010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V010[]> Handle(GetAllV010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V010.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V010));
                }

                return result;
            }
        }
    }
}
