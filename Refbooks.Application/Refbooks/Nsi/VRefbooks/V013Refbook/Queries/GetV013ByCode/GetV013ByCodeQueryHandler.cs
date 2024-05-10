
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetV013ByCode
{
    public class GetV013ByCodeQueryHandler : IRequestHandler<GetV013ByCodeQuery, V013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V013[]> Handle(GetV013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V013.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V013), request.Code);
                }

                return entities;
            }
        }
    }
}
