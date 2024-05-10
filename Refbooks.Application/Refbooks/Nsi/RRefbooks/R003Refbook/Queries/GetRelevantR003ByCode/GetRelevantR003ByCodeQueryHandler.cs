
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetRelevantR003ByCode
{
    public class GetRelevantR003ByCodeQueryHandler : IRequestHandler<GetRelevantR003ByCodeQuery, R003>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R003> Handle(GetRelevantR003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R003.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R003), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
