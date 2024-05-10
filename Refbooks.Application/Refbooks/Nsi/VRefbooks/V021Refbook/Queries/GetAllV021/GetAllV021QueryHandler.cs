
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetAllV021
{
    public class GetAllV021QueryHandler : IRequestHandler<GetAllV021Query, V021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V021[]> Handle(GetAllV021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V021.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V021));
                }

                return result;
            }
        }
    }
}
