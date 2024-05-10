
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetV018ByCode
{
    public class GetV018ByCodeQueryHandler : IRequestHandler<GetV018ByCodeQuery, V018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV018ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V018[]> Handle(GetV018ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V018.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V018), request.Code);
                }

                return entities;
            }
        }
    }
}
