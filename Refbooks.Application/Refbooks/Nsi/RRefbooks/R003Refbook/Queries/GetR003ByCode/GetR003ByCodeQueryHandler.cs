
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetR003ByCode
{
    public class GetR003ByCodeQueryHandler : IRequestHandler<GetR003ByCodeQuery, R003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetR003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<R003[]> Handle(GetR003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.R003.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(R003), request.Code);
                }

                return entities;
            }
        }
    }
}
