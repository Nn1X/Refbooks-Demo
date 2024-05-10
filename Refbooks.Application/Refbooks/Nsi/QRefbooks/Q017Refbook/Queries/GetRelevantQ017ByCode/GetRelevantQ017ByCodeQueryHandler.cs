
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetRelevantQ017ByCode
{
    public class GetRelevantQ017ByCodeQueryHandler : IRequestHandler<GetRelevantQ017ByCodeQuery, Q017>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantQ017ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q017> Handle(GetRelevantQ017ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.Q017.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(Q017), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
