
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetRelevantR005ByCode
{
    public class GetRelevantR005ByCodeQueryHandler : IRequestHandler<GetRelevantR005ByCodeQuery, R005>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R005> Handle(GetRelevantR005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R005.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R005), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
