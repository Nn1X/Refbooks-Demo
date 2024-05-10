
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetAllV032
{
    public class GetAllV032QueryHandler : IRequestHandler<GetAllV032Query, V032[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV032QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V032[]> Handle(GetAllV032Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V032.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V032));
                }

                return result;
            }
        }
    }
}
