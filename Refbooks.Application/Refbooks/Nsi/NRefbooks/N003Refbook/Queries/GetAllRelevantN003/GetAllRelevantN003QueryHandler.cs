
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetAllRelevantN003
{
    public class GetAllRelevantN003QueryHandler : IRequestHandler<GetAllRelevantN003Query, N003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N003[]> Handle(GetAllRelevantN003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N003.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N003));
                }

                return result;
            }
        }
    }
}
