
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetV031ByCode
{
    public class GetV031ByCodeQueryHandler : IRequestHandler<GetV031ByCodeQuery, V031[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV031ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V031[]> Handle(GetV031ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V031.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V031), request.Code);
                }

                return entities;
            }
        }
    }
}
