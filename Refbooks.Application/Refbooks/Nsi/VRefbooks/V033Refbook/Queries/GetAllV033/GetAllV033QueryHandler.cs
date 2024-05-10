
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetAllV033
{
    public class GetAllV033QueryHandler : IRequestHandler<GetAllV033Query, V033[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV033QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V033[]> Handle(GetAllV033Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V033.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V033));
                }

                return result;
            }
        }
    }
}
