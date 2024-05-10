
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetQ023ByCode
{
    public class GetQ023ByCodeQueryHandler : IRequestHandler<GetQ023ByCodeQuery, Q023[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ023ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q023[]> Handle(GetQ023ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q023.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q023), request.Code);
                }

                return entities;
            }
        }
    }
}
