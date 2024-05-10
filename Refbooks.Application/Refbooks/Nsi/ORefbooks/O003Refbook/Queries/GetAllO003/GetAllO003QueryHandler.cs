
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O003Refbook.Queries.GetAllO003
{
    public class GetAllO003QueryHandler : IRequestHandler<GetAllO003Query, O003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllO003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<O003[]> Handle(GetAllO003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.O003.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(O003));
                }

                return result;
            }
        }
    }
}
