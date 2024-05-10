
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetAllQ021
{
    public class GetAllQ021QueryHandler : IRequestHandler<GetAllQ021Query, Q021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ021QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q021[]> Handle(GetAllQ021Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q021.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q021));
                }

                return result;
            }
        }
    }
}
