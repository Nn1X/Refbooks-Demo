
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetRelevantN019ByCode
{
    public class GetRelevantN019ByCodeQueryHandler : IRequestHandler<GetRelevantN019ByCodeQuery, N019>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N019> Handle(GetRelevantN019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N019.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N019), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
