
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetN017ByCode
{
    public class GetN017ByCodeQueryHandler : IRequestHandler<GetN017ByCodeQuery, N017[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetN017ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<N017[]> Handle(GetN017ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entities = await context.N017.Where(x => x.Code == request.Code)
                    .ToArrayAsync(cancellationToken);

                if (!entities.Any())
                {
                    throw new NotFoundException(nameof(N017), request.Code);
                }

                return entities;
            }
        }
    }
}
