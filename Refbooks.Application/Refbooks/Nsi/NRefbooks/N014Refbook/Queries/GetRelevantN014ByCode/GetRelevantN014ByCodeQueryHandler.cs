
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetRelevantN014ByCode
{
    public class GetRelevantN014ByCodeQueryHandler : IRequestHandler<GetRelevantN014ByCodeQuery, N014>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN014ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N014> Handle(GetRelevantN014ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N014.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N014), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
