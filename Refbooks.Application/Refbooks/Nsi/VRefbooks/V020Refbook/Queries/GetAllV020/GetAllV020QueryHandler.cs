
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetAllV020
{
    public class GetAllV020QueryHandler : IRequestHandler<GetAllV020Query, V020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV020QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V020[]> Handle(GetAllV020Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V020.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V020));
                }

                return result;
            }
        }
    }
}
