
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetR013ByCode
{
    public class GetR013ByCodeQueryHandler : IRequestHandler<GetR013ByCodeQuery, R013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R013[]> Handle(GetR013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R013.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R013), request.Code);
                }

                return entities;
            }
        }
    }
}
