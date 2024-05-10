
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetAllRelevantV009
{
    public class GetAllRelevantV009QueryHandler : IRequestHandler<GetAllRelevantV009Query, V009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V009[]> Handle(GetAllRelevantV009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V009.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V009));
                }

                return result;
            }
        }
    }
}
