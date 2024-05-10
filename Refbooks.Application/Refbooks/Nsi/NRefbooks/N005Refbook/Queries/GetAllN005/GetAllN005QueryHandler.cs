
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetAllN005
{
    public class GetAllN005QueryHandler : IRequestHandler<GetAllN005Query, N005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN005QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N005[]> Handle(GetAllN005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N005.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N005));
                }

                return result;
            }
        }
    }
}
