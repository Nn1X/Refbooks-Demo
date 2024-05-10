
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetRelevantV002ByCode
{
    public class GetRelevantV002ByCodeQueryHandler : IRequestHandler<GetRelevantV002ByCodeQuery, V002>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V002> Handle(GetRelevantV002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V002.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V002), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
