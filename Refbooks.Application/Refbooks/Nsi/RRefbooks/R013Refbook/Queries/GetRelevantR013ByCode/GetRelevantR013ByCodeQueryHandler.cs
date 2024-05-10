
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetRelevantR013ByCode
{
    public class GetRelevantR013ByCodeQueryHandler : IRequestHandler<GetRelevantR013ByCodeQuery, R013>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R013> Handle(GetRelevantR013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R013.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R013), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
