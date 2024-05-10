
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V005Refbook.Queries.GetAllV005
{
    public class GetAllV005QueryHandler : IRequestHandler<GetAllV005Query, V005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV005QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V005[]> Handle(GetAllV005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V005.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V005));
                }

                return result;
            }
        }
    }
}
