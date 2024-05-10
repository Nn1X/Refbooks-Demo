
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N018Refbook.Queries.GetAllN018
{
    public class GetAllN018QueryHandler : IRequestHandler<GetAllN018Query, N018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN018QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N018[]> Handle(GetAllN018Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N018.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N018));
                }

                return result;
            }
        }
    }
}
