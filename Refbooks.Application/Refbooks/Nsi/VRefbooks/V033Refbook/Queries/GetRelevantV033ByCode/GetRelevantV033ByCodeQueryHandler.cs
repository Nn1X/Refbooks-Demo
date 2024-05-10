
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetRelevantV033ByCode
{
    public class GetRelevantV033ByCodeQueryHandler : IRequestHandler<GetRelevantV033ByCodeQuery, V033>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV033ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V033> Handle(GetRelevantV033ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V033.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V033), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
