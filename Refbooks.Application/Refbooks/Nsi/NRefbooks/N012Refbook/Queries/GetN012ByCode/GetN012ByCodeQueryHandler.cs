
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetN012ByCode
{
    public class GetN012ByCodeQueryHandler : IRequestHandler<GetN012ByCodeQuery, N012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN012ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N012[]> Handle(GetN012ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N012.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N012), request.Code);
                }

                return entities;
            }
        }
    }
}
