
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetQ016ByCode
{
    public class GetQ016ByCodeQueryHandler : IRequestHandler<GetQ016ByCodeQuery, Q016[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ016ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q016[]> Handle(GetQ016ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q016.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q016), request.Code);
                }

                return entities;
            }
        }
    }
}
