
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetRelevantQ021ByCode
{
    public class GetRelevantQ021ByCodeQueryHandler : IRequestHandler<GetRelevantQ021ByCodeQuery, Q021>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ021ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q021> Handle(GetRelevantQ021ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q021.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q021), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
