
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetAllR008
{
    public class GetAllR008QueryHandler : IRequestHandler<GetAllR008Query, R008[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR008QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R008[]> Handle(GetAllR008Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R008.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R008));
                }

                return result;
            }
        }
    }
}
