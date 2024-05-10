
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N010Refbook.Queries.GetAllN010
{
    public class GetAllN010QueryHandler : IRequestHandler<GetAllN010Query, N010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N010[]> Handle(GetAllN010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N010.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N010));
                }

                return result;
            }
        }
    }
}
