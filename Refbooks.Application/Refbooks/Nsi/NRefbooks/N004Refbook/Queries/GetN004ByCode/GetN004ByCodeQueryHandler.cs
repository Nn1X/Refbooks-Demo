
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetN004ByCode
{
    public class GetN004ByCodeQueryHandler : IRequestHandler<GetN004ByCodeQuery, N004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN004ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N004[]> Handle(GetN004ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N004.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N004), request.Code);
                }

                return entities;
            }
        }
    }
}
