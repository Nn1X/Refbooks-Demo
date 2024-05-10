
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetV037ByCode
{
    public class GetV037ByCodeQueryHandler : IRequestHandler<GetV037ByCodeQuery, V037[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV037ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V037[]> Handle(GetV037ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V037.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V037), request.Code);
                }

                return entities;
            }
        }
    }
}
