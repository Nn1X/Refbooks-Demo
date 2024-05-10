
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetAllN017
{
    public class GetAllN017QueryHandler : IRequestHandler<GetAllN017Query, N017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllN017QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N017[]> Handle(GetAllN017Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N017.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N017));
                }

                return result;
            }
        }
    }
}
