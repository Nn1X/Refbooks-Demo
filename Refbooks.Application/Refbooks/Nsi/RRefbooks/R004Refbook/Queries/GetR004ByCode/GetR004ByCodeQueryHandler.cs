
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetR004ByCode
{
    public class GetR004ByCodeQueryHandler : IRequestHandler<GetR004ByCodeQuery, R004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR004ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R004[]> Handle(GetR004ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R004.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R004), request.Code);
                }

                return entities;
            }
        }
    }
}
