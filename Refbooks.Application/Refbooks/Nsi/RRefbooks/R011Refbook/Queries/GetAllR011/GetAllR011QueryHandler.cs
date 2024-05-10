
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetAllR011
{
    public class GetAllR011QueryHandler : IRequestHandler<GetAllR011Query, R011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR011QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R011[]> Handle(GetAllR011Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R011.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R011));
                }

                return result;
            }
        }
    }
}
