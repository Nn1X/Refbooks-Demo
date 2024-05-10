
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetQ019ByCode
{
    public class GetQ019ByCodeQueryHandler : IRequestHandler<GetQ019ByCodeQuery, Q019[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ019ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q019[]> Handle(GetQ019ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q019.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q019), request.Code);
                }

                return entities;
            }
        }
    }
}
