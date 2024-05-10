
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetRelevantV015ByCode
{
    public class GetRelevantV015ByCodeQueryHandler : IRequestHandler<GetRelevantV015ByCodeQuery, V015>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V015> Handle(GetRelevantV015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V015.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V015), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
