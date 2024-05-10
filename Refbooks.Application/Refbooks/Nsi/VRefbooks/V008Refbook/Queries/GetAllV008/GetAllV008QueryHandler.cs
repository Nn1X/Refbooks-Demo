
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetAllV008
{
    public class GetAllV008QueryHandler : IRequestHandler<GetAllV008Query, V008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V008[]> Handle(GetAllV008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V008.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V008));
                }

                return result;
            }
        }
    }
}
