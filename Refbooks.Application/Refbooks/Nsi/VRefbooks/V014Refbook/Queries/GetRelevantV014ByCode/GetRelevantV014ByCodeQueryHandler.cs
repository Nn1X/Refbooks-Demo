
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetRelevantV014ByCode
{
    public class GetRelevantV014ByCodeQueryHandler : IRequestHandler<GetRelevantV014ByCodeQuery, V014>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV014ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V014> Handle(GetRelevantV014ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V014.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V014), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
