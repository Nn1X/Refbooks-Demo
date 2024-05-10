
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O004Refbook.Queries.GetO004ByCode
{
    public class GetO004ByCodeQueryHandler : IRequestHandler<GetO004ByCodeQuery, O004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetO004ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<O004[]> Handle(GetO004ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.O004.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(O004), request.Code);
                }

                return entities;
            }
        }
    }
}
