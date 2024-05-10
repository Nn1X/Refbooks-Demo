
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetAllV015
{
    public class GetAllV015QueryHandler : IRequestHandler<GetAllV015Query, V015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV015QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V015[]> Handle(GetAllV015Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V015.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V015));
                }

                return result;
            }
        }
    }
}
