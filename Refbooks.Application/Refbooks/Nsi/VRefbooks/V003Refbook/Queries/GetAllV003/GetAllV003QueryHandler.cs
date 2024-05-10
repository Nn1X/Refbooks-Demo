
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetAllV003
{
    public class GetAllV003QueryHandler : IRequestHandler<GetAllV003Query, V003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V003[]> Handle(GetAllV003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V003.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V003));
                }

                return result;
            }
        }
    }
}
