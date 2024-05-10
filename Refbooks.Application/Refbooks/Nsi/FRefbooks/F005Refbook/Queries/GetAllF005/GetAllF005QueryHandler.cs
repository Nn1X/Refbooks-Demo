using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetAllF005
{
    public class GetAllF005QueryHandler : IRequestHandler<GetAllF005Query, F005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;
        public GetAllF005QueryHandler(IRefbooksDbContextFactory dbFactory)
            => _dbFactory = dbFactory;

        public async Task<F005[]> Handle(GetAllF005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F005.ToArrayAsync();

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F005));
                }

                return result;
            }
        }
    }
}
