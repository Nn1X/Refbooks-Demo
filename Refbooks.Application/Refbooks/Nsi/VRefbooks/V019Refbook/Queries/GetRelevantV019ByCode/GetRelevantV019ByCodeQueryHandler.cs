
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetRelevantV019ByCode
{
    public class GetRelevantV019ByCodeQueryHandler : IRequestHandler<GetRelevantV019ByCodeQuery, V019>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V019> Handle(GetRelevantV019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V019.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V019), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
