
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetRelevantN003ByCode
{
    public class GetRelevantN003ByCodeQueryHandler : IRequestHandler<GetRelevantN003ByCodeQuery, N003>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N003> Handle(GetRelevantN003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N003.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N003), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
