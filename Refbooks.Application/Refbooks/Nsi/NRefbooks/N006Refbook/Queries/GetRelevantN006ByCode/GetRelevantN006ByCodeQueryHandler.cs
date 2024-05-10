
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetRelevantN006ByCode
{
    public class GetRelevantN006ByCodeQueryHandler : IRequestHandler<GetRelevantN006ByCodeQuery, N006>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N006> Handle(GetRelevantN006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N006.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N006), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
