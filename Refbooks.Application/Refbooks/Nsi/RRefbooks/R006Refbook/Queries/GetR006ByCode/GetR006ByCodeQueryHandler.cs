
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetR006ByCode
{
    public class GetR006ByCodeQueryHandler : IRequestHandler<GetR006ByCodeQuery, R006[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR006ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R006[]> Handle(GetR006ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R006.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R006), request.Code);
                }

                return entities;
            }
        }
    }
}
