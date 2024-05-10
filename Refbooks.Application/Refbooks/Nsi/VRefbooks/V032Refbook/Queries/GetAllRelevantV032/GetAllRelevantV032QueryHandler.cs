
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetAllRelevantV032
{
    public class GetAllRelevantV032QueryHandler : IRequestHandler<GetAllRelevantV032Query, V032[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV032QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V032[]> Handle(GetAllRelevantV032Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V032.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V032));
                }

                return result;
            }
        }
    }
}
