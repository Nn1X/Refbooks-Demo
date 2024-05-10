
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetRelevantV013ByCode
{
    public class GetRelevantV013ByCodeQueryHandler : IRequestHandler<GetRelevantV013ByCodeQuery, V013>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V013> Handle(GetRelevantV013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V013.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V013), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
