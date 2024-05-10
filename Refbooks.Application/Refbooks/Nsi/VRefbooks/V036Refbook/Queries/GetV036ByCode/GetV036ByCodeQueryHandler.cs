
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetV036ByCode
{
    public class GetV036ByCodeQueryHandler : IRequestHandler<GetV036ByCodeQuery, V036[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV036ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V036[]> Handle(GetV036ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V036.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V036), request.Code);
                }

                return entities;
            }
        }
    }
}
