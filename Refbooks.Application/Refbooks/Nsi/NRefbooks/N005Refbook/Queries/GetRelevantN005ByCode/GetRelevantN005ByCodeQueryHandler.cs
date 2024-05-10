
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetRelevantN005ByCode
{
    public class GetRelevantN005ByCodeQueryHandler : IRequestHandler<GetRelevantN005ByCodeQuery, N005>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N005> Handle(GetRelevantN005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N005.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N005), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
