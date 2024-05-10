
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetR008ByCode
{
    public class GetR008ByCodeQueryHandler : IRequestHandler<GetR008ByCodeQuery, R008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR008ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R008[]> Handle(GetR008ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R008.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R008), request.Code);
                }

                return entities;
            }
        }
    }
}
