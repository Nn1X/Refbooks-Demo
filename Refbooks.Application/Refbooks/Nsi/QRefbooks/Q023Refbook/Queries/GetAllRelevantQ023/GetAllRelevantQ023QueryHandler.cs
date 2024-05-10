
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetAllRelevantQ023
{
    public class GetAllRelevantQ023QueryHandler : IRequestHandler<GetAllRelevantQ023Query, Q023[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantQ023QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q023[]> Handle(GetAllRelevantQ023Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q023.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q023));
                }

                return result;
            }
        }
    }
}
