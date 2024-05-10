
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetAllRelevantV033
{
    public class GetAllRelevantV033QueryHandler : IRequestHandler<GetAllRelevantV033Query, V033[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV033QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V033[]> Handle(GetAllRelevantV033Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V033.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V033));
                }

                return result;
            }
        }
    }
}
