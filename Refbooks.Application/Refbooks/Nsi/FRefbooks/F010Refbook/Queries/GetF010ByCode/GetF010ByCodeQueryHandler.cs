using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetF010ByCode
{
    public class GetF010ByCodeQueryHandler : IRequestHandler<GetF010ByCodeQuery, F010[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF010ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F010[]> Handle(GetF010ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.F010.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(F010), request.Code);
                }

                return entities;
            }
        }
    }
}
