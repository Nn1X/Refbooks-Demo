
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetRelevantV031ByCode
{
    public class GetRelevantV031ByCodeQueryHandler : IRequestHandler<GetRelevantV031ByCodeQuery, V031>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV031ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V031> Handle(GetRelevantV031ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V031.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V031), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
