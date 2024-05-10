
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetV012ByCode
{
    public class GetV012ByCodeQueryHandler : IRequestHandler<GetV012ByCodeQuery, V012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetV012ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<V012[]> Handle(GetV012ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.V012.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(V012), request.Code);
                }

                return entities;
            }
        }
    }
}
