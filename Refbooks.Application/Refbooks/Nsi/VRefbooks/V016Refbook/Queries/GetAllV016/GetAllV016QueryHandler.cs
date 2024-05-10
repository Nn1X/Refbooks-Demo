
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetAllV016
{
    public class GetAllV016QueryHandler : IRequestHandler<GetAllV016Query, V016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV016QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V016[]> Handle(GetAllV016Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V016.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V016));
                }

                return result;
            }
        }
    }
}
