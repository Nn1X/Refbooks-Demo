
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetAllRelevantV012
{
    public class GetAllRelevantV012QueryHandler : IRequestHandler<GetAllRelevantV012Query, V012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V012[]> Handle(GetAllRelevantV012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V012.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V012));
                }

                return result;
            }
        }
    }
}
