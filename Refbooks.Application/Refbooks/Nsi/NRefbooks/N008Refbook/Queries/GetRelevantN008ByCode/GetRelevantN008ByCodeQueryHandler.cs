
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N008Refbook.Queries.GetRelevantN008ByCode
{
    public class GetRelevantN008ByCodeQueryHandler : IRequestHandler<GetRelevantN008ByCodeQuery, N008>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN008ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N008> Handle(GetRelevantN008ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N008.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N008), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
