
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetV009ByCode
{
    public class GetV009ByCodeQueryHandler : IRequestHandler<GetV009ByCodeQuery, V009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV009ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V009[]> Handle(GetV009ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V009.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V009), request.Code);
                }

                return entities;
            }
        }
    }
}
