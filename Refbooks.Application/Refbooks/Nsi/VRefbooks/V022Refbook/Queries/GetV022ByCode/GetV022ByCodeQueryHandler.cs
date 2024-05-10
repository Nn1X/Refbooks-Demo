
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetV022ByCode
{
    public class GetV022ByCodeQueryHandler : IRequestHandler<GetV022ByCodeQuery, V022[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV022ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V022[]> Handle(GetV022ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V022.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V022), request.Code);
                }

                return entities;
            }
        }
    }
}
