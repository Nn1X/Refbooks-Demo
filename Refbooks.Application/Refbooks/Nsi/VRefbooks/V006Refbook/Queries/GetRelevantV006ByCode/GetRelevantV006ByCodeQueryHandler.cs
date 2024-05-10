
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetRelevantV006ByCode
{
    public class GetRelevantV006ByCodeQueryHandler : IRequestHandler<GetRelevantV006ByCodeQuery, V006>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V006> Handle(GetRelevantV006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V006.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V006), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
