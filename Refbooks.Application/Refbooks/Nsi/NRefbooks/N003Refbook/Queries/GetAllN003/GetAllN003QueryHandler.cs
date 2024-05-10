
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetAllN003
{
    public class GetAllN003QueryHandler : IRequestHandler<GetAllN003Query, N003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N003[]> Handle(GetAllN003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N003.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N003));
                }

                return result;
            }
        }
    }
}
