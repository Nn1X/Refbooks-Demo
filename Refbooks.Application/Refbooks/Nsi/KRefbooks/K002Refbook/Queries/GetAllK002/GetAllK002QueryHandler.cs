
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.KRefbooks.K002Refbook.Queries.GetAllK002
{
    public class GetAllK002QueryHandler : IRequestHandler<GetAllK002Query, K002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllK002QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<K002[]> Handle(GetAllK002Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.K002.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(K002));
                }

                return result;
            }
        }
    }
}
