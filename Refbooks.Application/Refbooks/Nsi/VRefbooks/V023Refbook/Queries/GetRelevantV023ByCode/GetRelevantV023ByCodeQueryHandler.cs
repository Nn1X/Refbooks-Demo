
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetRelevantV023ByCode
{
    public class GetRelevantV023ByCodeQueryHandler : IRequestHandler<GetRelevantV023ByCodeQuery, V023>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV023ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V023> Handle(GetRelevantV023ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V023.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V023), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
