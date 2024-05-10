using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F001Refbook.Queries.GetAllF001
{
    public class GetAllF001QueryHandler : IRequestHandler<GetAllF001Query, F001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF001QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F001[]> Handle(GetAllF001Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F001.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F001));
                }

                return result;
            }
        }
    }
}
