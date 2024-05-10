
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetAllRelevantV019
{
    public class GetAllRelevantV019QueryHandler : IRequestHandler<GetAllRelevantV019Query, V019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV019QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V019[]> Handle(GetAllRelevantV019Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V019.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V019));
                }

                return result;
            }
        }
    }
}
