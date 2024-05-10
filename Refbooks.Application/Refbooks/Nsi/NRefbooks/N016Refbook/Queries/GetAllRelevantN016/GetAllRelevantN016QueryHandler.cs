
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetAllRelevantN016
{
    public class GetAllRelevantN016QueryHandler : IRequestHandler<GetAllRelevantN016Query, N016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN016QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N016[]> Handle(GetAllRelevantN016Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N016.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N016));
                }

                return result;
            }
        }
    }
}
