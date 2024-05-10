
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetAllV012
{
    public class GetAllV012QueryHandler : IRequestHandler<GetAllV012Query, V012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V012[]> Handle(GetAllV012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V012.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V012));
                }

                return result;
            }
        }
    }
}
