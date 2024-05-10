
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetRelevantV016ByCode
{
    public class GetRelevantV016ByCodeQueryHandler : IRequestHandler<GetRelevantV016ByCodeQuery, V016>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV016ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V016> Handle(GetRelevantV016ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V016.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V016), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
