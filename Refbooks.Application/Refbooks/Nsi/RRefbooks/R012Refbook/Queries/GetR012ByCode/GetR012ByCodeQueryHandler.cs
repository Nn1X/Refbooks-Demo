
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetR012ByCode
{
    public class GetR012ByCodeQueryHandler : IRequestHandler<GetR012ByCodeQuery, R012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR012ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R012[]> Handle(GetR012ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R012.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R012), request.Code);
                }

                return entities;
            }
        }
    }
}
