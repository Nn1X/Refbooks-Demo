
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetRelevantR006ByCode
{
    public class GetRelevantR006ByCodeQueryHandler : IRequestHandler<GetRelevantR006ByCodeQuery, R006>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R006> Handle(GetRelevantR006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R006.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R006), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
