
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetN005ByCode
{
    public class GetN005ByCodeQueryHandler : IRequestHandler<GetN005ByCodeQuery, N005[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N005[]> Handle(GetN005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N005.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N005), request.Code);
                }

                return entities;
            }
        }
    }
}
