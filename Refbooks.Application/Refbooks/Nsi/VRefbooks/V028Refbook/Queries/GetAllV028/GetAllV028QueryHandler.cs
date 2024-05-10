
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetAllV028
{
    public class GetAllV028QueryHandler : IRequestHandler<GetAllV028Query, V028[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV028QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V028[]> Handle(GetAllV028Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V028.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V028));
                }

                return result;
            }
        }
    }
}
