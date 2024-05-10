
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetV010ByCode
{
    public class GetV010ByCodeQueryHandler : IRequestHandler<GetV010ByCodeQuery, V010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV010ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V010[]> Handle(GetV010ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V010.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V010), request.Code);
                }

                return entities;
            }
        }
    }
}
