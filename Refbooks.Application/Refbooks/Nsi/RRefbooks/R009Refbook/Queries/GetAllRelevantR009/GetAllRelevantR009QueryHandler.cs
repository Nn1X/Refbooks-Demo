
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetAllRelevantR009
{
    public class GetAllRelevantR009QueryHandler : IRequestHandler<GetAllRelevantR009Query, R009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR009QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R009[]> Handle(GetAllRelevantR009Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R009.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R009));
                }

                return result;
            }
        }
    }
}
