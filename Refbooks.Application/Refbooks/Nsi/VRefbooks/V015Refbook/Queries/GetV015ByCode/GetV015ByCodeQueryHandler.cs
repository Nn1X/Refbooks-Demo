
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetV015ByCode
{
    public class GetV015ByCodeQueryHandler : IRequestHandler<GetV015ByCodeQuery, V015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V015[]> Handle(GetV015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V015.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V015), request.Code);
                }

                return entities;
            }
        }
    }
}
