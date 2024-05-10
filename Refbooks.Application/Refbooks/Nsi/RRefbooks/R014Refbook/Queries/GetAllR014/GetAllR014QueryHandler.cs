
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetAllR014
{
    public class GetAllR014QueryHandler : IRequestHandler<GetAllR014Query, R014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R014[]> Handle(GetAllR014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R014.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R014));
                }

                return result;
            }
        }
    }
}
