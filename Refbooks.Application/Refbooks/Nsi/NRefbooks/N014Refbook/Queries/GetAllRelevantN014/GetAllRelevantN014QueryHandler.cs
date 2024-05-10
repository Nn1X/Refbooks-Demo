
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetAllRelevantN014
{
    public class GetAllRelevantN014QueryHandler : IRequestHandler<GetAllRelevantN014Query, N014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N014[]> Handle(GetAllRelevantN014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N014.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N014));
                }

                return result;
            }
        }
    }
}
