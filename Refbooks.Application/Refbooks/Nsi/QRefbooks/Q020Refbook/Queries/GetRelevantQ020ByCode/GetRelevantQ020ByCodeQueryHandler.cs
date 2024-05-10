
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q020Refbook.Queries.GetRelevantQ020ByCode
{
    public class GetRelevantQ020ByCodeQueryHandler : IRequestHandler<GetRelevantQ020ByCodeQuery, Q020>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q020> Handle(GetRelevantQ020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q020.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q020), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
