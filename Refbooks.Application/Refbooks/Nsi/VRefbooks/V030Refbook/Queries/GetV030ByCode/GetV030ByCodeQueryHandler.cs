
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetV030ByCode
{
    public class GetV030ByCodeQueryHandler : IRequestHandler<GetV030ByCodeQuery, V030[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV030ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V030[]> Handle(GetV030ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V030.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V030), request.Code);
                }

                return entities;
            }
        }
    }
}
