
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetAllQ017
{
    public class GetAllQ017QueryHandler : IRequestHandler<GetAllQ017Query, Q017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ017QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q017[]> Handle(GetAllQ017Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q017.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q017));
                }

                return result;
            }
        }
    }
}
