
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetRelevantR002ByCode
{
    public class GetRelevantR002ByCodeQueryHandler : IRequestHandler<GetRelevantR002ByCodeQuery, R002>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R002> Handle(GetRelevantR002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R002.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R002), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
