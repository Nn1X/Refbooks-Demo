using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetAllF014
{
    public class GetAllF014QueryHandler : IRequestHandler<GetAllF014Query, F014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF014QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F014[]> Handle(GetAllF014Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F014.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F014));
                }

                return result;
            }
        }
    }
}
