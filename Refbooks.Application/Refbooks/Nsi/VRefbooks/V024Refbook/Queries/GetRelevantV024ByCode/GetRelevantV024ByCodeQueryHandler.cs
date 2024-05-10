
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetRelevantV024ByCode
{
    public class GetRelevantV024ByCodeQueryHandler : IRequestHandler<GetRelevantV024ByCodeQuery, V024>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV024ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V024> Handle(GetRelevantV024ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V024.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V024), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
