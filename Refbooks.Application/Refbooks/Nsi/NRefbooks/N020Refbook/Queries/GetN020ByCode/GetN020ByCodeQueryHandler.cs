
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetN020ByCode
{
    public class GetN020ByCodeQueryHandler : IRequestHandler<GetN020ByCodeQuery, N020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N020[]> Handle(GetN020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N020.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N020), request.Code);
                }

                return entities;
            }
        }
    }
}
