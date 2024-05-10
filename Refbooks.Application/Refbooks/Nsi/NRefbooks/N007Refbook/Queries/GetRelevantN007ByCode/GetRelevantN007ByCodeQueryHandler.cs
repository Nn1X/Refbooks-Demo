
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetRelevantN007ByCode
{
    public class GetRelevantN007ByCodeQueryHandler : IRequestHandler<GetRelevantN007ByCodeQuery, N007>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN007ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N007> Handle(GetRelevantN007ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N007.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N007), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
