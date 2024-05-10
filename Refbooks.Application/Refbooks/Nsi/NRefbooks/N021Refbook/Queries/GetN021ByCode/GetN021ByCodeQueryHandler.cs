
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetN021ByCode
{
    public class GetN021ByCodeQueryHandler : IRequestHandler<GetN021ByCodeQuery, N021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN021ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N021[]> Handle(GetN021ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N021.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N021), request.Code);
                }

                return entities;
            }
        }
    }
}
