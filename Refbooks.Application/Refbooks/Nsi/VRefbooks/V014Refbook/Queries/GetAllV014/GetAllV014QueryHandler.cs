
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetAllV014
{
    public class GetAllV014QueryHandler : IRequestHandler<GetAllV014Query, V014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V014[]> Handle(GetAllV014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V014.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V014));
                }

                return result;
            }
        }
    }
}
