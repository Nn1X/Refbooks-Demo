
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetAllR005
{
    public class GetAllR005QueryHandler : IRequestHandler<GetAllR005Query, R005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR005QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R005[]> Handle(GetAllR005Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R005.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R005));
                }

                return result;
            }
        }
    }
}
