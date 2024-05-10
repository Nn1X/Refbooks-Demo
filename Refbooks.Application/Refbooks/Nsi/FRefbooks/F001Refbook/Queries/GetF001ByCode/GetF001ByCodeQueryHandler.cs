using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F001Refbook.Queries.GetF001ByCode
{
    public class GetF001ByCodeQueryHandler : IRequestHandler<GetF001ByCodeQuery, F001>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF001ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F001> Handle(GetF001ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F001.Where(x => x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F001), request.Code);
                }

                return entity;
            }
        }
    }
}
