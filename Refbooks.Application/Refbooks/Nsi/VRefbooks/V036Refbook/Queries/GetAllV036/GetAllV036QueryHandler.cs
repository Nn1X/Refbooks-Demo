
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetAllV036
{
    public class GetAllV036QueryHandler : IRequestHandler<GetAllV036Query, V036[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV036QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V036[]> Handle(GetAllV036Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V036.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V036));
                }

                return result;
            }
        }
    }
}
