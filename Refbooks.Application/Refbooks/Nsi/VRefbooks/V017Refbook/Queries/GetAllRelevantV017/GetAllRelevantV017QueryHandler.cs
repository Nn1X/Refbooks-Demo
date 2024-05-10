
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetAllRelevantV017
{
    public class GetAllRelevantV017QueryHandler : IRequestHandler<GetAllRelevantV017Query, V017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV017QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V017[]> Handle(GetAllRelevantV017Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V017.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V017));
                }

                return result;
            }
        }
    }
}
