
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetAllN013
{
    public class GetAllN013QueryHandler : IRequestHandler<GetAllN013Query, N013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN013QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N013[]> Handle(GetAllN013Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N013.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N013));
                }

                return result;
            }
        }
    }
}
