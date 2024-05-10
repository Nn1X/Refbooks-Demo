
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetRelevantV017ByCode
{
    public class GetRelevantV017ByCodeQueryHandler : IRequestHandler<GetRelevantV017ByCodeQuery, V017>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV017ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V017> Handle(GetRelevantV017ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V017.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V017), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
