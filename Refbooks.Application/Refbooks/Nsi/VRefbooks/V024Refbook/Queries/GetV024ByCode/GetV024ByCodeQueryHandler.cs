
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetV024ByCode
{
    public class GetV024ByCodeQueryHandler : IRequestHandler<GetV024ByCodeQuery, V024[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV024ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V024[]> Handle(GetV024ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V024.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V024), request.Code);
                }

                return entities;
            }
        }
    }
}
