
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetAllN019
{
    public class GetAllN019QueryHandler : IRequestHandler<GetAllN019Query, N019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN019QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N019[]> Handle(GetAllN019Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N019.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N019));
                }

                return result;
            }
        }
    }
}
