
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetV032ByCode
{
    public class GetV032ByCodeQueryHandler : IRequestHandler<GetV032ByCodeQuery, V032[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV032ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V032[]> Handle(GetV032ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V032.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V032), request.Code);
                }

                return entities;
            }
        }
    }
}
