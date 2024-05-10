
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetV006ByCode
{
    public class GetV006ByCodeQueryHandler : IRequestHandler<GetV006ByCodeQuery, V006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V006[]> Handle(GetV006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V006.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V006), request.Code);
                }

                return entities;
            }
        }
    }
}
