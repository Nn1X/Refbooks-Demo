
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetRelevantV018ByCode
{
    public class GetRelevantV018ByCodeQueryHandler : IRequestHandler<GetRelevantV018ByCodeQuery, V018>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV018ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V018> Handle(GetRelevantV018ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V018.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V018), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
