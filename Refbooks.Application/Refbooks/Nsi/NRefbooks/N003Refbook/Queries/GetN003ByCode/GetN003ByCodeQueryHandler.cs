
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetN003ByCode
{
    public class GetN003ByCodeQueryHandler : IRequestHandler<GetN003ByCodeQuery, N003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N003[]> Handle(GetN003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N003.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N003), request.Code);
                }

                return entities;
            }
        }
    }
}
