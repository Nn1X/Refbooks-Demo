
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetQ018ByCode
{
    public class GetQ018ByCodeQueryHandler : IRequestHandler<GetQ018ByCodeQuery, Q018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ018ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q018[]> Handle(GetQ018ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q018.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q018), request.Code);
                }

                return entities;
            }
        }
    }
}
