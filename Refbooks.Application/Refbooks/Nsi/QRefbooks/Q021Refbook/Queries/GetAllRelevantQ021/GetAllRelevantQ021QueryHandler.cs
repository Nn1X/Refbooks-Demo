
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetAllRelevantQ021
{
    public class GetAllRelevantQ021QueryHandler : IRequestHandler<GetAllRelevantQ021Query, Q021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantQ021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q021[]> Handle(GetAllRelevantQ021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q021.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q021));
                }

                return result;
            }
        }
    }
}
