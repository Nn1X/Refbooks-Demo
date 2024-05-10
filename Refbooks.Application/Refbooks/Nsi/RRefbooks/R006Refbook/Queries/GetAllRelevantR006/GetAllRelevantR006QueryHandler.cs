
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetAllRelevantR006
{
    public class GetAllRelevantR006QueryHandler : IRequestHandler<GetAllRelevantR006Query, R006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR006QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R006[]> Handle(GetAllRelevantR006Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R006.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R006));
                }

                return result;
            }
        }
    }
}
