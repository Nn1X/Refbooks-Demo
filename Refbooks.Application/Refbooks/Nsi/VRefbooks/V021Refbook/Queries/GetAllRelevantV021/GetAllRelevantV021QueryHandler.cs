
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetAllRelevantV021
{
    public class GetAllRelevantV021QueryHandler : IRequestHandler<GetAllRelevantV021Query, V021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V021[]> Handle(GetAllRelevantV021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V021.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V021));
                }

                return result;
            }
        }
    }
}
