
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetRelevantV025ByCode
{
    public class GetRelevantV025ByCodeQueryHandler : IRequestHandler<GetRelevantV025ByCodeQuery, V025>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV025ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V025> Handle(GetRelevantV025ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V025.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V025), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
