
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetR002ByCode
{
    public class GetR002ByCodeQueryHandler : IRequestHandler<GetR002ByCodeQuery, R002[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R002[]> Handle(GetR002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R002.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R002), request.Code);
                }

                return entities;
            }
        }
    }
}
