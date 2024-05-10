
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetAllRelevantV015
{
    public class GetAllRelevantV015QueryHandler : IRequestHandler<GetAllRelevantV015Query, V015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV015QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V015[]> Handle(GetAllRelevantV015Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V015.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V015));
                }

                return result;
            }
        }
    }
}
