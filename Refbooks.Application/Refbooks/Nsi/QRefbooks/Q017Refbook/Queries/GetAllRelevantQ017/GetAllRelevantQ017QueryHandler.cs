
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetAllRelevantQ017
{
    public class GetAllRelevantQ017QueryHandler : IRequestHandler<GetAllRelevantQ017Query, Q017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantQ017QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q017[]> Handle(GetAllRelevantQ017Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q017.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q017));
                }

                return result;
            }
        }
    }
}
