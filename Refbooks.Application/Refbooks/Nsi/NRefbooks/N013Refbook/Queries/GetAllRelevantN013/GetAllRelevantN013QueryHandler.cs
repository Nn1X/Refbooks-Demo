
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetAllRelevantN013
{
    public class GetAllRelevantN013QueryHandler : IRequestHandler<GetAllRelevantN013Query, N013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN013QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N013[]> Handle(GetAllRelevantN013Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N013.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N013));
                }

                return result;
            }
        }
    }
}
