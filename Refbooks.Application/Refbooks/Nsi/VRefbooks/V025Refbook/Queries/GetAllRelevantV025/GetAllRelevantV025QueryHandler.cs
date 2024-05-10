
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetAllRelevantV025
{
    public class GetAllRelevantV025QueryHandler : IRequestHandler<GetAllRelevantV025Query, V025[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV025QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V025[]> Handle(GetAllRelevantV025Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V025.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V025));
                }

                return result;
            }
        }
    }
}
