
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetAllRelevantR003
{
    public class GetAllRelevantR003QueryHandler : IRequestHandler<GetAllRelevantR003Query, R003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R003[]> Handle(GetAllRelevantR003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R003.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R003));
                }

                return result;
            }
        }
    }
}
