
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O001Refbook.Queries.GetAllO001
{
    public class GetAllO001QueryHandler : IRequestHandler<GetAllO001Query, O001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllO001QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<O001[]> Handle(GetAllO001Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.O001.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(O001));
                }

                return result;
            }
        }
    }
}
