
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetR007ByCode
{
    public class GetR007ByCodeQueryHandler : IRequestHandler<GetR007ByCodeQuery, R007[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R007[]> Handle(GetR007ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R007.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R007), request.Code);
                }

                return entities;
            }
        }
    }
}
