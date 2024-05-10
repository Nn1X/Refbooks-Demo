using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetAllF010
{
    public class GetAllF010QueryHandler : IRequestHandler<GetAllF010Query, F010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F010[]> Handle(GetAllF010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F010.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F010));
                }

                return result;
            }
        }
    }
}
