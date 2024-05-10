
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetV029ByCode
{
    public class GetV029ByCodeQueryHandler : IRequestHandler<GetV029ByCodeQuery, V029[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV029ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V029[]> Handle(GetV029ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V029.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V029), request.Code);
                }

                return entities;
            }
        }
    }
}
