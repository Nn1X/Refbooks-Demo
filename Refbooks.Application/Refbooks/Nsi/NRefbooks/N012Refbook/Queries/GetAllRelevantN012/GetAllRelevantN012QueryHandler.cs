
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetAllRelevantN012
{
    public class GetAllRelevantN012QueryHandler : IRequestHandler<GetAllRelevantN012Query, N012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N012[]> Handle(GetAllRelevantN012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N012.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N012));
                }

                return result;
            }
        }
    }
}
