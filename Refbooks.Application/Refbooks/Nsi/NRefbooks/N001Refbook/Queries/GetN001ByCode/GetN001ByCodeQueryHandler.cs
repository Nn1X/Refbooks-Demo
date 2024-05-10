
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N001Refbook.Queries.GetN001ByCode
{
    public class GetN001ByCodeQueryHandler : IRequestHandler<GetN001ByCodeQuery, N001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN001ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N001[]> Handle(GetN001ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N001.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N001), request.Code);
                }

                return entities;
            }
        }
    }
}
