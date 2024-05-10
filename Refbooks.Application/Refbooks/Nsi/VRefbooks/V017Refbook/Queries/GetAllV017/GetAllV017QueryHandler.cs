
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetAllV017
{
    public class GetAllV017QueryHandler : IRequestHandler<GetAllV017Query, V017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV017QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V017[]> Handle(GetAllV017Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V017.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V017));
                }

                return result;
            }
        }
    }
}
