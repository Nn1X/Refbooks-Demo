
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetRelevantQ019ByCode
{
    public class GetRelevantQ019ByCodeQueryHandler : IRequestHandler<GetRelevantQ019ByCodeQuery, Q019>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q019> Handle(GetRelevantQ019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q019.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q019), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
