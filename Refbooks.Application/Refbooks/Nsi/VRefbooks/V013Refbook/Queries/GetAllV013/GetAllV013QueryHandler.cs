
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetAllV013
{
    public class GetAllV013QueryHandler : IRequestHandler<GetAllV013Query, V013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV013QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V013[]> Handle(GetAllV013Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V013.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V013));
                }

                return result;
            }
        }
    }
}
