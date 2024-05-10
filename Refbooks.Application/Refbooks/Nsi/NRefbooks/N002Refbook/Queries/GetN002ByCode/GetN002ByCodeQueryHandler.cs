
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N002Refbook.Queries.GetN002ByCode
{
    public class GetN002ByCodeQueryHandler : IRequestHandler<GetN002ByCodeQuery, N002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N002[]> Handle(GetN002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N002.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N002), request.Code);
                }

                return entities;
            }
        }
    }
}
