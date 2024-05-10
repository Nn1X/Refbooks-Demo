
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetRelevantQ023ByCode
{
    public class GetRelevantQ023ByCodeQueryHandler : IRequestHandler<GetRelevantQ023ByCodeQuery, Q023>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ023ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q023> Handle(GetRelevantQ023ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q023.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q023), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
