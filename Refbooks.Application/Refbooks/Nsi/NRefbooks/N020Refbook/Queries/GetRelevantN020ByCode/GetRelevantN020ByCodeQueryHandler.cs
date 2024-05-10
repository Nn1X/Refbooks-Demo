
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetRelevantN020ByCode
{
    public class GetRelevantN020ByCodeQueryHandler : IRequestHandler<GetRelevantN020ByCodeQuery, N020>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N020> Handle(GetRelevantN020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N020.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N020), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
