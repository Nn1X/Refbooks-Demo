
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetAllN012
{
    public class GetAllN012QueryHandler : IRequestHandler<GetAllN012Query, N012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N012[]> Handle(GetAllN012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N012.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N012));
                }

                return result;
            }
        }
    }
}
