
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetV021ByCode
{
    public class GetV021ByCodeQueryHandler : IRequestHandler<GetV021ByCodeQuery, V021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV021ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V021[]> Handle(GetV021ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V021.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V021), request.Code);
                }

                return entities;
            }
        }
    }
}
