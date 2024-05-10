
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N002Refbook.Queries.GetRelevantN002ByCode
{
    public class GetRelevantN002ByCodeQueryHandler : IRequestHandler<GetRelevantN002ByCodeQuery, N002>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N002> Handle(GetRelevantN002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N002.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N002), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
