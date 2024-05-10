using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetAllRelevantF010
{
    public class GetAllRelevantF010QueryHandler : IRequestHandler<GetAllRelevantF010Query, F010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantF010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F010[]> Handle(GetAllRelevantF010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F010.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F010));
                }

                return result;
            }
        }
    }
}
