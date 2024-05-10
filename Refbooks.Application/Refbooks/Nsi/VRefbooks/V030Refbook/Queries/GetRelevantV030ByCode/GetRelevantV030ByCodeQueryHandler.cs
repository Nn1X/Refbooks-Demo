
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetRelevantV030ByCode
{
    public class GetRelevantV030ByCodeQueryHandler : IRequestHandler<GetRelevantV030ByCodeQuery, V030>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV030ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V030> Handle(GetRelevantV030ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V030.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V030), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
