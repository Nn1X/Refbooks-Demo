
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetAllRelevantN006
{
    public class GetAllRelevantN006QueryHandler : IRequestHandler<GetAllRelevantN006Query, N006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN006QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N006[]> Handle(GetAllRelevantN006Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N006.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N006));
                }

                return result;
            }
        }
    }
}
