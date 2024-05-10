
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N010Refbook.Queries.GetRelevantN010ByCode
{
    public class GetRelevantN010ByCodeQueryHandler : IRequestHandler<GetRelevantN010ByCodeQuery, N010>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN010ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N010> Handle(GetRelevantN010ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N010.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N010), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
