
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetR001ByCode
{
    public class GetR001ByCodeQueryHandler : IRequestHandler<GetR001ByCodeQuery, R001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR001ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R001[]> Handle(GetR001ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R001.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R001), request.Code);
                }

                return entities;
            }
        }
    }
}
