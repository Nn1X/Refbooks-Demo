
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetRelevantR004ByCode
{
    public class GetRelevantR004ByCodeQueryHandler : IRequestHandler<GetRelevantR004ByCodeQuery, R004>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantR004ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R004> Handle(GetRelevantR004ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.R004.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(R004), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
