
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetAllRelevantR008
{
    public class GetAllRelevantR008QueryHandler : IRequestHandler<GetAllRelevantR008Query, R008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R008[]> Handle(GetAllRelevantR008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R008.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R008));
                }

                return result;
            }
        }
    }
}
