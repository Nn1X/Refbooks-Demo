
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetAllR007
{
    public class GetAllR007QueryHandler : IRequestHandler<GetAllR007Query, R007[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR007QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R007[]> Handle(GetAllR007Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R007.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R007));
                }

                return result;
            }
        }
    }
}
