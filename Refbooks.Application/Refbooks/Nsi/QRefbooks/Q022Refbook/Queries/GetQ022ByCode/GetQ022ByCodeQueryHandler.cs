
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q022Refbook.Queries.GetQ022ByCode
{
    public class GetQ022ByCodeQueryHandler : IRequestHandler<GetQ022ByCodeQuery, Q022[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ022ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q022[]> Handle(GetQ022ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q022.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q022), request.Code);
                }

                return entities;
            }
        }
    }
}
