
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetRelevantV010ByCode
{
    public class GetRelevantV010ByCodeQueryHandler : IRequestHandler<GetRelevantV010ByCodeQuery, V010>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV010ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V010> Handle(GetRelevantV010ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V010.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V010), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
