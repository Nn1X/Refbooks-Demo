
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetV002ByCode
{
    public class GetV002ByCodeQueryHandler : IRequestHandler<GetV002ByCodeQuery, V002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V002[]> Handle(GetV002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V002.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V002), request.Code);
                }

                return entities;
            }
        }
    }
}
