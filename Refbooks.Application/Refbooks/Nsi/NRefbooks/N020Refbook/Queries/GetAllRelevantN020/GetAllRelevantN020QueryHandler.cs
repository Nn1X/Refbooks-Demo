
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetAllRelevantN020
{
    public class GetAllRelevantN020QueryHandler : IRequestHandler<GetAllRelevantN020Query, N020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN020QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N020[]> Handle(GetAllRelevantN020Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N020.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N020));
                }

                return result;
            }
        }
    }
}
