
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetAllRelevantV029
{
    public class GetAllRelevantV029QueryHandler : IRequestHandler<GetAllRelevantV029Query, V029[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV029QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V029[]> Handle(GetAllRelevantV029Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V029.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V029));
                }

                return result;
            }
        }
    }
}
