using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetAllRelevantF005
{
    public class GetAllRelevantF005QueryHandler : IRequestHandler<GetAllRelevantF005Query, F005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;
        public GetAllRelevantF005QueryHandler(IRefbooksDbContextFactory dbFactory)
            => _dbFactory = dbFactory;

        public async Task<F005[]> Handle(GetAllRelevantF005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F005.Where(x => x.DateBegin <= request.Date
                    && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync();

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F005));
                }

                return result;
            }
        }
    }
}
