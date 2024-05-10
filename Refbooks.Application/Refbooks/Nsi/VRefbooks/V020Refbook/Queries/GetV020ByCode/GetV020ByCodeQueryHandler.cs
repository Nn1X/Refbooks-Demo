
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetV020ByCode
{
    public class GetV020ByCodeQueryHandler : IRequestHandler<GetV020ByCodeQuery, V020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V020[]> Handle(GetV020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V020.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V020), request.Code);
                }

                return entities;
            }
        }
    }
}
