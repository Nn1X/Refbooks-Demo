
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O005Refbook.Queries.GetAllO005
{
    public class GetAllO005QueryHandler : IRequestHandler<GetAllO005Query, O005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllO005QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<O005[]> Handle(GetAllO005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.O005.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(O005));
                }

                return result;
            }
        }
    }
}
