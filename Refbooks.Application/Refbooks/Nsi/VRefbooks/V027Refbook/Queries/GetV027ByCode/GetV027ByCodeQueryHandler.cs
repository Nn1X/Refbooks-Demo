
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetV027ByCode
{
    public class GetV027ByCodeQueryHandler : IRequestHandler<GetV027ByCodeQuery, V027[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV027ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V027[]> Handle(GetV027ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V027.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V027), request.Code);
                }

                return entities;
            }
        }
    }
}
