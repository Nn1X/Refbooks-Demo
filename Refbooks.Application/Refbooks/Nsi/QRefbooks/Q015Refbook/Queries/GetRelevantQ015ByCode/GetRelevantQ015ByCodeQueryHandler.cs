
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetRelevantQ015ByCode
{
    public class GetRelevantQ015ByCodeQueryHandler : IRequestHandler<GetRelevantQ015ByCodeQuery, Q015>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q015> Handle(GetRelevantQ015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q015.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q015), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
