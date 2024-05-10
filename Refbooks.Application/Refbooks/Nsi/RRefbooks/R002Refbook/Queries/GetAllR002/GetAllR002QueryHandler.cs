
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetAllR002
{
    public class GetAllR002QueryHandler : IRequestHandler<GetAllR002Query, R002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR002QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R002[]> Handle(GetAllR002Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R002.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R002));
                }

                return result;
            }
        }
    }
}
