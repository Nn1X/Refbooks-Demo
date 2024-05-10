
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetV025ByCode
{
    public class GetV025ByCodeQueryHandler : IRequestHandler<GetV025ByCodeQuery, V025[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV025ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V025[]> Handle(GetV025ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V025.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V025), request.Code);
                }

                return entities;
            }
        }
    }
}
