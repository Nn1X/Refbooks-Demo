
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetQ015ByCode
{
    public class GetQ015ByCodeQueryHandler : IRequestHandler<GetQ015ByCodeQuery, Q015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q015[]> Handle(GetQ015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q015.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q015), request.Code);
                }

                return entities;
            }
        }
    }
}
