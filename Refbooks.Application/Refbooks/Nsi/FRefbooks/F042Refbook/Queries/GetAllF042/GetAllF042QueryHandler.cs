
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetAllF042
{
    public class GetAllF042QueryHandler : IRequestHandler<GetAllF042Query, F042[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF042QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F042[]> Handle(GetAllF042Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F042.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F042));
                }

                return result;
            }
        }
    }
}
