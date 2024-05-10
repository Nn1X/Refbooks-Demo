
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetRelevantR007ByCode
{
    public class GetRelevantR007ByCodeQueryHandler : IRequestHandler<GetRelevantR007ByCodeQuery, R007>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R007> Handle(GetRelevantR007ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R007.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R007), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
