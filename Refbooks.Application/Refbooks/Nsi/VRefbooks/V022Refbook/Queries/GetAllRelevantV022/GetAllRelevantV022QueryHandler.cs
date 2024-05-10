
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetAllRelevantV022
{
    public class GetAllRelevantV022QueryHandler : IRequestHandler<GetAllRelevantV022Query, V022[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV022QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V022[]> Handle(GetAllRelevantV022Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V022.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V022));
                }

                return result;
            }
        }
    }
}
