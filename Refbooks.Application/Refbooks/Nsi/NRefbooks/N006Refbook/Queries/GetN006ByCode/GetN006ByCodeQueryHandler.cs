
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetN006ByCode
{
    public class GetN006ByCodeQueryHandler : IRequestHandler<GetN006ByCodeQuery, N006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N006[]> Handle(GetN006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N006.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N006), request.Code);
                }

                return entities;
            }
        }
    }
}
