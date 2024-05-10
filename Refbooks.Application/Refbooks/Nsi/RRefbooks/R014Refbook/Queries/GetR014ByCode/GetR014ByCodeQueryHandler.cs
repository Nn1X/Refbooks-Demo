
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetR014ByCode
{
    public class GetR014ByCodeQueryHandler : IRequestHandler<GetR014ByCodeQuery, R014[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR014ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R014[]> Handle(GetR014ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R014.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R014), request.Code);
                }

                return entities;
            }
        }
    }
}
