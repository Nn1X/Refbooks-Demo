
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O001Refbook.Queries.GetO001ByCode
{
    public class GetO001ByCodeQueryHandler : IRequestHandler<GetO001ByCodeQuery, O001>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetO001ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<O001> Handle(GetO001ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.O001.Where(x => x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(O001), request.Code);
                }

                return entity;
            }
        }
    }
}
