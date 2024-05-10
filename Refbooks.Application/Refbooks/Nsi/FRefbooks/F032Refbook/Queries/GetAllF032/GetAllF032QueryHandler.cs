
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F032Refbook.Queries.GetAllF032
{
    public class GetAllF032QueryHandler : IRequestHandler<GetAllF032Query, F032[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF032QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F032[]> Handle(GetAllF032Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F032.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F032));
                }

                return result;
            }
        }
    }
}
