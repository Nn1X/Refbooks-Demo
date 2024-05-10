
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetRelevantV036ByCode
{
    public class GetRelevantV036ByCodeQueryHandler : IRequestHandler<GetRelevantV036ByCodeQuery, V036>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV036ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V036> Handle(GetRelevantV036ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V036.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V036), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
