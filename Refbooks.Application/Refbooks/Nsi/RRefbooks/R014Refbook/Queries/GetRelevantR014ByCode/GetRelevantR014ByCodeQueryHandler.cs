
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetRelevantR014ByCode
{
    public class GetRelevantR014ByCodeQueryHandler : IRequestHandler<GetRelevantR014ByCodeQuery, R014>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR014ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R014> Handle(GetRelevantR014ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R014.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R014), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
