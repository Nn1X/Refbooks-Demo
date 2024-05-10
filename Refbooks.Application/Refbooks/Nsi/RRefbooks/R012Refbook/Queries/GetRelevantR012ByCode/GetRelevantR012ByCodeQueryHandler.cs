
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetRelevantR012ByCode
{
    public class GetRelevantR012ByCodeQueryHandler : IRequestHandler<GetRelevantR012ByCodeQuery, R012>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR012ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R012> Handle(GetRelevantR012ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R012.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R012), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
