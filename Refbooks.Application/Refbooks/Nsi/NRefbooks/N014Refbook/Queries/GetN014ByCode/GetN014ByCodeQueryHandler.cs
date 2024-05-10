
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetN014ByCode
{
    public class GetN014ByCodeQueryHandler : IRequestHandler<GetN014ByCodeQuery, N014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN014ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N014[]> Handle(GetN014ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N014.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N014), request.Code);
                }

                return entities;
            }
        }
    }
}
