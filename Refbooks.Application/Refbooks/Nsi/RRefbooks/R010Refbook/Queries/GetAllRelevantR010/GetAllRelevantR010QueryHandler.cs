
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetAllRelevantR010
{
    public class GetAllRelevantR010QueryHandler : IRequestHandler<GetAllRelevantR010Query, R010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R010[]> Handle(GetAllRelevantR010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R010.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R010));
                }

                return result;
            }
        }
    }
}
