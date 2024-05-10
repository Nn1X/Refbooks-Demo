
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetAllRelevantR012
{
    public class GetAllRelevantR012QueryHandler : IRequestHandler<GetAllRelevantR012Query, R012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R012[]> Handle(GetAllRelevantR012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R012.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R012));
                }

                return result;
            }
        }
    }
}
