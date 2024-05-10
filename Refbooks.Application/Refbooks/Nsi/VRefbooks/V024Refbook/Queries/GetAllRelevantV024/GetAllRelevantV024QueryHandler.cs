
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetAllRelevantV024
{
    public class GetAllRelevantV024QueryHandler : IRequestHandler<GetAllRelevantV024Query, V024[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV024QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V024[]> Handle(GetAllRelevantV024Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V024.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V024));
                }

                return result;
            }
        }
    }
}
