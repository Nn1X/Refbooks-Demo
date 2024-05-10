
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetAllRelevantV030
{
    public class GetAllRelevantV030QueryHandler : IRequestHandler<GetAllRelevantV030Query, V030[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV030QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V030[]> Handle(GetAllRelevantV030Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V030.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V030));
                }

                return result;
            }
        }
    }
}
