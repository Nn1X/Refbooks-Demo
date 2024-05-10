
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetR005ByCode
{
    public class GetR005ByCodeQueryHandler : IRequestHandler<GetR005ByCodeQuery, R005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R005[]> Handle(GetR005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R005.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R005), request.Code);
                }

                return entities;
            }
        }
    }
}
