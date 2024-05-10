
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetAllV006
{
    public class GetAllV006QueryHandler : IRequestHandler<GetAllV006Query, V006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV006QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V006[]> Handle(GetAllV006Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V006.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V006));
                }

                return result;
            }
        }
    }
}
