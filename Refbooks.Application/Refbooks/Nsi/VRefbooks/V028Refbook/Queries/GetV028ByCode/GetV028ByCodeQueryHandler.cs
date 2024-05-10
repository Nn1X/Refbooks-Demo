
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetV028ByCode
{
    public class GetV028ByCodeQueryHandler : IRequestHandler<GetV028ByCodeQuery, V028[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV028ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V028[]> Handle(GetV028ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V028.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V028), request.Code);
                }

                return entities;
            }
        }
    }
}
