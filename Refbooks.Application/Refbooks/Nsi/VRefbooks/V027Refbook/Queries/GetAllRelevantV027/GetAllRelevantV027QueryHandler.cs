
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetAllRelevantV027
{
    public class GetAllRelevantV027QueryHandler : IRequestHandler<GetAllRelevantV027Query, V027[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV027QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V027[]> Handle(GetAllRelevantV027Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V027.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V027));
                }

                return result;
            }
        }
    }
}
