
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetR011ByCode
{
    public class GetR011ByCodeQueryHandler : IRequestHandler<GetR011ByCodeQuery, R011[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR011ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R011[]> Handle(GetR011ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R011.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R011), request.Code);
                }

                return entities;
            }
        }
    }
}
