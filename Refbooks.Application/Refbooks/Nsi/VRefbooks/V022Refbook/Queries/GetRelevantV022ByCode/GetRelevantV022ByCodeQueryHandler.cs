
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetRelevantV022ByCode
{
    public class GetRelevantV022ByCodeQueryHandler : IRequestHandler<GetRelevantV022ByCodeQuery, V022>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV022ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V022> Handle(GetRelevantV022ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V022.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V022), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
