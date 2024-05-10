
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetRelevantN004ByCode
{
    public class GetRelevantN004ByCodeQueryHandler : IRequestHandler<GetRelevantN004ByCodeQuery, N004>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN004ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N004> Handle(GetRelevantN004ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N004.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N004), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
