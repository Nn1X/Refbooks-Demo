
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N018Refbook.Queries.GetAllRelevantN018
{
    public class GetAllRelevantN018QueryHandler : IRequestHandler<GetAllRelevantN018Query, N018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantN018QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N018[]> Handle(GetAllRelevantN018Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.N018.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(N018));
                }

                return result;
            }
        }
    }
}
