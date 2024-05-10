
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetAllV024
{
    public class GetAllV024QueryHandler : IRequestHandler<GetAllV024Query, V024[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV024QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V024[]> Handle(GetAllV024Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V024.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V024));
                }

                return result;
            }
        }
    }
}
