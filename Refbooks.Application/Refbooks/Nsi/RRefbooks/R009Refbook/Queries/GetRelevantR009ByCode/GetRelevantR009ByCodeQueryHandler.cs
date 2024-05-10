
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetRelevantR009ByCode
{
    public class GetRelevantR009ByCodeQueryHandler : IRequestHandler<GetRelevantR009ByCodeQuery, R009>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR009ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R009> Handle(GetRelevantR009ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R009.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R009), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
