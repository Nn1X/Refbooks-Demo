
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetAllQ016
{
    public class GetAllQ016QueryHandler : IRequestHandler<GetAllQ016Query, Q016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ016QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q016[]> Handle(GetAllQ016Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q016.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q016));
                }

                return result;
            }
        }
    }
}
