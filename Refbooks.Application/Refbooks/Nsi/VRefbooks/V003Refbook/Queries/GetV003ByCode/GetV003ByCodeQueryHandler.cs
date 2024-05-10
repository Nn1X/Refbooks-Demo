
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetV003ByCode
{
    public class GetV003ByCodeQueryHandler : IRequestHandler<GetV003ByCodeQuery, V003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V003[]> Handle(GetV003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V003.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V003), request.Code);
                }

                return entities;
            }
        }
    }
}
