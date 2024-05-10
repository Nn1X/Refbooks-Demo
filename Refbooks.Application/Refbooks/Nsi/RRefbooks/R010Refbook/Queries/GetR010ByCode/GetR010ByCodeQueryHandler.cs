
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetR010ByCode
{
    public class GetR010ByCodeQueryHandler : IRequestHandler<GetR010ByCodeQuery, R010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR010ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R010[]> Handle(GetR010ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R010.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R010), request.Code);
                }

                return entities;
            }
        }
    }
}
