
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetRelevantV027ByCode
{
    public class GetRelevantV027ByCodeQueryHandler : IRequestHandler<GetRelevantV027ByCodeQuery, V027>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV027ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V027> Handle(GetRelevantV027ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V027.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V027), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
