
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F032Refbook.Queries.GetRelevantF032ByCode
{
    public class GetRelevantF032ByCodeQueryHandler : IRequestHandler<GetRelevantF032ByCodeQuery, F032>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantF032ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F032> Handle(GetRelevantF032ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F032.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F032), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
