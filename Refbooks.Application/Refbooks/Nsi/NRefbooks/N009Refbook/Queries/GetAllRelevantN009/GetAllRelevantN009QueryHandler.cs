
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetAllRelevantN009
{
    public class GetAllRelevantN009QueryHandler : IRequestHandler<GetAllRelevantN009Query, N009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N009[]> Handle(GetAllRelevantN009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N009.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N009));
                }

                return result;
            }
        }
    }
}
