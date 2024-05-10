
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetAllRelevantV026
{
    public class GetAllRelevantV026QueryHandler : IRequestHandler<GetAllRelevantV026Query, V026[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV026QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V026[]> Handle(GetAllRelevantV026Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V026.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V026));
                }

                return result;
            }
        }
    }
}
