
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetAllV029
{
    public class GetAllV029QueryHandler : IRequestHandler<GetAllV029Query, V029[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV029QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V029[]> Handle(GetAllV029Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V029.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V029));
                }

                return result;
            }
        }
    }
}
