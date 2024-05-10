
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetAllRelevantV037
{
    public class GetAllRelevantV037QueryHandler : IRequestHandler<GetAllRelevantV037Query, V037[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV037QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V037[]> Handle(GetAllRelevantV037Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V037.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V037));
                }

                return result;
            }
        }
    }
}
