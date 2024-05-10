
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetV016ByCode
{
    public class GetV016ByCodeQueryHandler : IRequestHandler<GetV016ByCodeQuery, V016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV016ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V016[]> Handle(GetV016ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V016.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V016), request.Code);
                }

                return entities;
            }
        }
    }
}
