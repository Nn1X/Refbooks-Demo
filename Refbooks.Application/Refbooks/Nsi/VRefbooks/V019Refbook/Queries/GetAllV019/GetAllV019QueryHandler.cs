
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetAllV019
{
    public class GetAllV019QueryHandler : IRequestHandler<GetAllV019Query, V019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV019QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V019[]> Handle(GetAllV019Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V019.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V019));
                }

                return result;
            }
        }
    }
}
