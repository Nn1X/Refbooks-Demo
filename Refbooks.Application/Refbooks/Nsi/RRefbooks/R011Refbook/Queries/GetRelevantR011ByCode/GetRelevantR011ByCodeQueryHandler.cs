
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetRelevantR011ByCode
{
    public class GetRelevantR011ByCodeQueryHandler : IRequestHandler<GetRelevantR011ByCodeQuery, R011>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR011ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R011> Handle(GetRelevantR011ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R011.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R011), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
