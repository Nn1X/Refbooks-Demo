
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetV023ByCode
{
    public class GetV023ByCodeQueryHandler : IRequestHandler<GetV023ByCodeQuery, V023[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV023ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V023[]> Handle(GetV023ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V023.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V023), request.Code);
                }

                return entities;
            }
        }
    }
}
