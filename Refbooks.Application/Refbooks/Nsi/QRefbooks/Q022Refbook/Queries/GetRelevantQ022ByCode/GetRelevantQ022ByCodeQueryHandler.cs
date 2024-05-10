
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q022Refbook.Queries.GetRelevantQ022ByCode
{
    public class GetRelevantQ022ByCodeQueryHandler : IRequestHandler<GetRelevantQ022ByCodeQuery, Q022>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ022ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q022> Handle(GetRelevantQ022ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q022.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q022), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
