
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetF042ByCode
{
    public class GetF042ByCodeQueryHandler : IRequestHandler<GetF042ByCodeQuery, F042[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF042ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F042[]> Handle(GetF042ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.F042.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(F042), request.Code);
                }

                return entities;
            }
        }
    }
}
