
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetAllRelevantN007
{
    public class GetAllRelevantN007QueryHandler : IRequestHandler<GetAllRelevantN007Query, N007[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN007QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N007[]> Handle(GetAllRelevantN007Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N007.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N007));
                }

                return result;
            }
        }
    }
}
