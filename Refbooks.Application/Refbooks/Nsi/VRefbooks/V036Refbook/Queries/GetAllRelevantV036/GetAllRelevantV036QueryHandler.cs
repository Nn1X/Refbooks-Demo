
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetAllRelevantV036
{
    public class GetAllRelevantV036QueryHandler : IRequestHandler<GetAllRelevantV036Query, V036[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV036QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V036[]> Handle(GetAllRelevantV036Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V036.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V036));
                }

                return result;
            }
        }
    }
}
