
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetRelevantF042ByCode
{
    public class GetRelevantF042ByCodeQueryHandler : IRequestHandler<GetRelevantF042ByCodeQuery, F042>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantF042ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F042> Handle(GetRelevantF042ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F042.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F042), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
