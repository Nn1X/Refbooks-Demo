
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetN019ByCode
{
    public class GetN019ByCodeQueryHandler : IRequestHandler<GetN019ByCodeQuery, N019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N019[]> Handle(GetN019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N019.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N019), request.Code);
                }

                return entities;
            }
        }
    }
}
