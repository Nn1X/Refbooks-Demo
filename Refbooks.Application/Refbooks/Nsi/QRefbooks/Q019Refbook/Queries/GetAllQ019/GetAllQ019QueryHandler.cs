
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetAllQ019
{
    public class GetAllQ019QueryHandler : IRequestHandler<GetAllQ019Query, Q019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ019QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q019[]> Handle(GetAllQ019Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q019.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q019));
                }

                return result;
            }
        }
    }
}
