
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetAllRelevantV010
{
    public class GetAllRelevantV010QueryHandler : IRequestHandler<GetAllRelevantV010Query, V010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V010[]> Handle(GetAllRelevantV010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V010.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V010));
                }

                return result;
            }
        }
    }
}
