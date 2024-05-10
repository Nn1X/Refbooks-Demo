
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetAllRelevantV031
{
    public class GetAllRelevantV031QueryHandler : IRequestHandler<GetAllRelevantV031Query, V031[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV031QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V031[]> Handle(GetAllRelevantV031Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V031.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V031));
                }

                return result;
            }
        }
    }
}
