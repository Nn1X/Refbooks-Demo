
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetF015ByCode
{
    public class GetF015ByCodeQueryHandler : IRequestHandler<GetF015ByCodeQuery, F015[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetF015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<F015[]> Handle(GetF015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.F015.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(F015), request.Code);
                }

                return entities;
            }
        }
    }
}
