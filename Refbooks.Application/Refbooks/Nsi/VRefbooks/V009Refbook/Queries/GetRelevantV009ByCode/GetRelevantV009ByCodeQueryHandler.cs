
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetRelevantV009ByCode
{
    public class GetRelevantV009ByCodeQueryHandler : IRequestHandler<GetRelevantV009ByCodeQuery, V009>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV009ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V009> Handle(GetRelevantV009ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V009.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V009), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
