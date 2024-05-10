
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetRelevantV020ByCode
{
    public class GetRelevantV020ByCodeQueryHandler : IRequestHandler<GetRelevantV020ByCodeQuery, V020>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V020> Handle(GetRelevantV020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V020.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V020), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
