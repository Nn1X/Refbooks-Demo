
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetRelevantQ018ByCode
{
    public class GetRelevantQ018ByCodeQueryHandler : IRequestHandler<GetRelevantQ018ByCodeQuery, Q018>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ018ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q018> Handle(GetRelevantQ018ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q018.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q018), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
