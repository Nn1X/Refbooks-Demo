using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F009Refbook.Queries.GetAllF009
{
    public class GetAllF009QueryHandler : IRequestHandler<GetAllF009Query, F009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F009[]> Handle(GetAllF009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F009.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F009));
                }

                return result;
            }
        }
    }
}
