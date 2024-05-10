
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q020Refbook.Queries.GetQ020ByCode
{
    public class GetQ020ByCodeQueryHandler : IRequestHandler<GetQ020ByCodeQuery, Q020[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetQ020ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<Q020[]> Handle(GetQ020ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.Q020.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(Q020), request.Code);
                }

                return entities;
            }
        }
    }
}
