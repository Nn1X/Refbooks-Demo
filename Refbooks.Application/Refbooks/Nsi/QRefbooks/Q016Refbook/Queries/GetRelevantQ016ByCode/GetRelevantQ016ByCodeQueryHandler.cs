
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetRelevantQ016ByCode
{
    public class GetRelevantQ016ByCodeQueryHandler : IRequestHandler<GetRelevantQ016ByCodeQuery, Q016>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ016ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q016> Handle(GetRelevantQ016ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q016.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q016), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
