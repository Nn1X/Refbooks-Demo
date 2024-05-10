
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetRelevantR001ByCode
{
    public class GetRelevantR001ByCodeQueryHandler : IRequestHandler<GetRelevantR001ByCodeQuery, R001>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR001ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R001> Handle(GetRelevantR001ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R001.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R001), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
