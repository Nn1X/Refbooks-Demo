
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetAllRelevantV014
{
    public class GetAllRelevantV014QueryHandler : IRequestHandler<GetAllRelevantV014Query, V014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V014[]> Handle(GetAllRelevantV014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V014.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V014));
                }

                return result;
            }
        }
    }
}
