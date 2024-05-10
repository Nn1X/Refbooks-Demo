
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetAllRelevantV028
{
    public class GetAllRelevantV028QueryHandler : IRequestHandler<GetAllRelevantV028Query, V028[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV028QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V028[]> Handle(GetAllRelevantV028Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V028.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V028));
                }

                return result;
            }
        }
    }
}
