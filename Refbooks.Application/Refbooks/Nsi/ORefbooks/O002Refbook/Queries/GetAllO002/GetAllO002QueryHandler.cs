
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O002Refbook.Queries.GetAllO002
{
    public class GetAllO002QueryHandler : IRequestHandler<GetAllO002Query, O002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllO002QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<O002[]> Handle(GetAllO002Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.O002.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(O002));
                }

                return result;
            }
        }
    }
}
