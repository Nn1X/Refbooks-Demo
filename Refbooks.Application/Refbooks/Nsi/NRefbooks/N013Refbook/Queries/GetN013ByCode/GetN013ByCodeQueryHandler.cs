
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetN013ByCode
{
    public class GetN013ByCodeQueryHandler : IRequestHandler<GetN013ByCodeQuery, N013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N013[]> Handle(GetN013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N013.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N013), request.Code);
                }

                return entities;
            }
        }
    }
}
