
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetAllRelevantR001
{
    public class GetAllRelevantR001QueryHandler : IRequestHandler<GetAllRelevantR001Query, R001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR001QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R001[]> Handle(GetAllRelevantR001Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R001.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R001));
                }

                return result;
            }
        }
    }
}
