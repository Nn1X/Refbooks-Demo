
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N015Refbook.Queries.GetRelevantN015ByCode
{
    public class GetRelevantN015ByCodeQueryHandler : IRequestHandler<GetRelevantN015ByCodeQuery, N015>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N015> Handle(GetRelevantN015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N015.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N015), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
