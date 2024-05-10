
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetRelevantV008ByCode
{
    public class GetRelevantV008ByCodeQueryHandler : IRequestHandler<GetRelevantV008ByCodeQuery, V008>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV008ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V008> Handle(GetRelevantV008ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V008.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V008), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
