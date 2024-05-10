
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetQ021ByCode
{
    public class GetQ021ByCodeQueryHandler : IRequestHandler<GetQ021ByCodeQuery, Q021[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ021ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q021[]> Handle(GetQ021ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q021.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q021), request.Code);
                }

                return entities;
            }
        }
    }
}
