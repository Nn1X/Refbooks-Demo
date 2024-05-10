using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetF005ByCode
{
    public class GetF005ByCodeQueryHandler : IRequestHandler<GetF005ByCodeQuery, F005>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;
        public GetF005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
            => _dbFactory = dbFactory;

        public async Task<F005> Handle(GetF005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F005.FirstOrDefaultAsync(x => x.Code == request.Code);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F005), request.Code);
                }

                return entity;
            }
        }
    }
}
