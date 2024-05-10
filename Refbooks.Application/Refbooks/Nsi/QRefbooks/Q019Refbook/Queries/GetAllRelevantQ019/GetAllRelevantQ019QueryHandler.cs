
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetAllRelevantQ019
{
    public class GetAllRelevantQ019QueryHandler : IRequestHandler<GetAllRelevantQ019Query, Q019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRelevantQ019QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q019[]> Handle(GetAllRelevantQ019Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q019.Where(x => x.DateBegin <= request.Date
                                                     && (x.DateEnd >= request.Date || x.DateEnd == null))
                    .ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q019));
                }

                return result;
            }
        }
    }
}
