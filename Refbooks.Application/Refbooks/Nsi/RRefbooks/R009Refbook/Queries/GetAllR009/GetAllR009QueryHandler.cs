
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetAllR009
{
    public class GetAllR009QueryHandler : IRequestHandler<GetAllR009Query, R009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R009[]> Handle(GetAllR009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R009.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R009));
                }

                return result;
            }
        }
    }
}
