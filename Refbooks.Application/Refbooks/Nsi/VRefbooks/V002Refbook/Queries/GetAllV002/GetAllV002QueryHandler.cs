
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetAllV002
{
    public class GetAllV002QueryHandler : IRequestHandler<GetAllV002Query, V002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV002QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V002[]> Handle(GetAllV002Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V002.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V002));
                }

                return result;
            }
        }
    }
}
