
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetAllRelevantN021
{
    public class GetAllRelevantN021QueryHandler : IRequestHandler<GetAllRelevantN021Query, N021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N021[]> Handle(GetAllRelevantN021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N021.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N021));
                }

                return result;
            }
        }
    }
}
