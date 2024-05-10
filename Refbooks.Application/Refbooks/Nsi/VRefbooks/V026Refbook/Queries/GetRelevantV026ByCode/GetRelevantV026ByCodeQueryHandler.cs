
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetRelevantV026ByCode
{
    public class GetRelevantV026ByCodeQueryHandler : IRequestHandler<GetRelevantV026ByCodeQuery, V026>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV026ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V026> Handle(GetRelevantV026ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V026.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V026), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
