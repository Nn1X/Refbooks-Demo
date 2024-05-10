
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetN009ByCode
{
    public class GetN009ByCodeQueryHandler : IRequestHandler<GetN009ByCodeQuery, N009[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN009ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N009[]> Handle(GetN009ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N009.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N009), request.Code);
                }

                return entities;
            }
        }
    }
}
