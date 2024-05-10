
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetAllRelevantV006
{
    public class GetAllRelevantV006QueryHandler : IRequestHandler<GetAllRelevantV006Query, V006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV006QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V006[]> Handle(GetAllRelevantV006Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V006.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V006));
                }

                return result;
            }
        }
    }
}
