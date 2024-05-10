
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O005Refbook.Queries.GetO005ByCode
{
    public class GetO005ByCodeQueryHandler : IRequestHandler<GetO005ByCodeQuery, O005>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetO005ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<O005> Handle(GetO005ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.O005.Where(x => x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(O005), request.Code);
                }

                return entity;
            }
        }
    }
}
