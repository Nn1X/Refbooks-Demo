
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N001Refbook.Queries.GetAllN001
{
    public class GetAllN001QueryHandler : IRequestHandler<GetAllN001Query, N001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN001QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N001[]> Handle(GetAllN001Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N001.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N001));
                }

                return result;
            }
        }
    }
}
