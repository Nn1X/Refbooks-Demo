using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetAllRelevantF008
{
    public class GetAllRelevantF008QueryHandler : IRequestHandler<GetAllRelevantF008Query, F008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantF008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F008[]> Handle(GetAllRelevantF008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F008.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F008));
                }

                return result;
            }
        }
    }
}
