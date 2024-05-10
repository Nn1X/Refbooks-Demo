using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetAllRelevantF014
{
    public class GetAllRelevantF014QueryHandler : IRequestHandler<GetAllRelevantF014Query, F014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantF014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F014[]> Handle(GetAllRelevantF014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F014.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F014));
                }

                return result;
            }
        }
    }
}
