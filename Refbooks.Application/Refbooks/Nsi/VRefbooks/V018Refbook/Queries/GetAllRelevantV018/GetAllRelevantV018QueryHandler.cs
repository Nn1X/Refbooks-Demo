
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetAllRelevantV018
{
    public class GetAllRelevantV018QueryHandler : IRequestHandler<GetAllRelevantV018Query, V018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantV018QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V018[]> Handle(GetAllRelevantV018Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V018.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V018));
                }

                return result;
            }
        }
    }
}
