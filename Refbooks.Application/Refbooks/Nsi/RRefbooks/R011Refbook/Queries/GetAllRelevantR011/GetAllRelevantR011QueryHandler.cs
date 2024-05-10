
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetAllRelevantR011
{
    public class GetAllRelevantR011QueryHandler : IRequestHandler<GetAllRelevantR011Query, R011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantR011QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R011[]> Handle(GetAllRelevantR011Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R011.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R011));
                }

                return result;
            }
        }
    }
}
