using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetAllF008
{
    public class GetAllF008QueryHandler : IRequestHandler<GetAllF008Query, F008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F008[]> Handle(GetAllF008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F008.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F008));
                }

                return result;
            }
        }
    }
}
