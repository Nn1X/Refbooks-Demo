
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetV019ByCode
{
    public class GetV019ByCodeQueryHandler : IRequestHandler<GetV019ByCodeQuery, V019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V019[]> Handle(GetV019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V019.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V019), request.Code);
                }

                return entities;
            }
        }
    }
}
