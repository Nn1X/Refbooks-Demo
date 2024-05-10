
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetV017ByCode
{
    public class GetV017ByCodeQueryHandler : IRequestHandler<GetV017ByCodeQuery, V017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV017ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V017[]> Handle(GetV017ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V017.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V017), request.Code);
                }

                return entities;
            }
        }
    }
}
