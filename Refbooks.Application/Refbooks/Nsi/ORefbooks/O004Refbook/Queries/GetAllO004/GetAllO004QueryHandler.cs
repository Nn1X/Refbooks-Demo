
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O004Refbook.Queries.GetAllO004
{
    public class GetAllO004QueryHandler : IRequestHandler<GetAllO004Query, O004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllO004QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<O004[]> Handle(GetAllO004Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.O004.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(O004));
                }

                return result;
            }
        }
    }
}
