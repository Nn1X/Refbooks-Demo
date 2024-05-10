using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetRelevantF008ByCode
{
    public class GetRelevantF008ByCodeQueryHandler : IRequestHandler<GetRelevantF008ByCodeQuery, F008>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantF008ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F008> Handle(GetRelevantF008ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F008.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F008), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
