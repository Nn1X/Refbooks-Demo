
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetAllR010
{
    public class GetAllR010QueryHandler : IRequestHandler<GetAllR010Query, R010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR010QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R010[]> Handle(GetAllR010Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R010.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R010));
                }

                return result;
            }
        }
    }
}
