
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetV026ByCode
{
    public class GetV026ByCodeQueryHandler : IRequestHandler<GetV026ByCodeQuery, V026[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV026ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V026[]> Handle(GetV026ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V026.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V026), request.Code);
                }

                return entities;
            }
        }
    }
}
