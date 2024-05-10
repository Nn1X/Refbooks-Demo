
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetAllRelevantV008
{
    public class GetAllRelevantV008QueryHandler : IRequestHandler<GetAllRelevantV008Query, V008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V008[]> Handle(GetAllRelevantV008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V008.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V008));
                }

                return result;
            }
        }
    }
}
