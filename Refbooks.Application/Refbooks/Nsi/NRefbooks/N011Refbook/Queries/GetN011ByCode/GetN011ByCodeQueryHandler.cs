
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetN011ByCode
{
    public class GetN011ByCodeQueryHandler : IRequestHandler<GetN011ByCodeQuery, N011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN011ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N011[]> Handle(GetN011ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N011.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N011), request.Code);
                }

                return entities;
            }
        }
    }
}
