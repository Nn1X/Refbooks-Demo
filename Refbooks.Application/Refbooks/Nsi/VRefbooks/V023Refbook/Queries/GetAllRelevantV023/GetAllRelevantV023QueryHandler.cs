
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetAllRelevantV023
{
    public class GetAllRelevantV023QueryHandler : IRequestHandler<GetAllRelevantV023Query, V023[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV023QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V023[]> Handle(GetAllRelevantV023Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V023.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V023));
                }

                return result;
            }
        }
    }
}
