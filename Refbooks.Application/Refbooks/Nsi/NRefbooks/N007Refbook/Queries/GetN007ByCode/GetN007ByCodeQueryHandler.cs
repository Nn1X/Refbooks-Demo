
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetN007ByCode
{
    public class GetN007ByCodeQueryHandler : IRequestHandler<GetN007ByCodeQuery, N007[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N007[]> Handle(GetN007ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N007.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N007), request.Code);
                }

                return entities;
            }
        }
    }
}
