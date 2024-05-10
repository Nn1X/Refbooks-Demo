
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.KRefbooks.K004Refbook.Queries.GetAllK004
{
    public class GetAllK004QueryHandler : IRequestHandler<GetAllK004Query, K004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllK004QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<K004[]> Handle(GetAllK004Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.K004.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(K004));
                }

                return result;
            }
        }
    }
}
