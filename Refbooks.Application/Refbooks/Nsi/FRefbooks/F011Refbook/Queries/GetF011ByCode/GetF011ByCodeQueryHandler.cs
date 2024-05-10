using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F011Refbook.Queries.GetF011ByCode
{
    public class GetF011ByCodeQueryHandler : IRequestHandler<GetF011ByCodeQuery, F011>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF011ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F011> Handle(GetF011ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F011.Where(x => x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F011), request.Code);
                }

                return entity;
            }
        }
    }
}
