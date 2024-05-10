
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N008Refbook.Queries.GetAllN008
{
    public class GetAllN008QueryHandler : IRequestHandler<GetAllN008Query, N008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N008[]> Handle(GetAllN008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N008.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N008));
                }

                return result;
            }
        }
    }
}
