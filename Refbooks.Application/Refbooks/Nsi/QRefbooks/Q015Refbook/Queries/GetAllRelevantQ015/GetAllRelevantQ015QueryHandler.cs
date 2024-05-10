
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetAllRelevantQ015
{
    public class GetAllRelevantQ015QueryHandler : IRequestHandler<GetAllRelevantQ015Query, Q015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantQ015QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q015[]> Handle(GetAllRelevantQ015Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q015.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q015));
                }

                return result;
            }
        }
    }
}
