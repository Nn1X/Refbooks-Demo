
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetAllQ015
{
    public class GetAllQ015QueryHandler : IRequestHandler<GetAllQ015Query, Q015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ015QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q015[]> Handle(GetAllQ015Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q015.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q015));
                }

                return result;
            }
        }
    }
}
