using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F009Refbook.Queries.GetF009ByCode
{
    public class GetF009ByCodeQueryHandler : IRequestHandler<GetF009ByCodeQuery, F009>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF009ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F009> Handle(GetF009ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F009.Where(x => x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F009), request.Code);
                }

                return entity;
            }
        }
    }
}
