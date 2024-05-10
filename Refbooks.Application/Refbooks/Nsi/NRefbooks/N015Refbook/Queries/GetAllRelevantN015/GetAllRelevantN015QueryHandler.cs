
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N015Refbook.Queries.GetAllRelevantN015
{
    public class GetAllRelevantN015QueryHandler : IRequestHandler<GetAllRelevantN015Query, N015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN015QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N015[]> Handle(GetAllRelevantN015Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N015.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N015));
                }

                return result;
            }
        }
    }
}
