using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F011Refbook.Queries.GetAllF011
{
    public class GetAllF011QueryHandler : IRequestHandler<GetAllF011Query, F011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllF011QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F011[]> Handle(GetAllF011Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.F011.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(F011));
                }

                return result;
            }
        }
    }
}
