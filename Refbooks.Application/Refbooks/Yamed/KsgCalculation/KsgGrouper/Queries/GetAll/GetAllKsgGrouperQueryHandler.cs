using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.KsgGrouper.Queries.GetAll
{
    public class GetAllKsgGrouperQueryHandler
        : IRequestHandler<GetAllKsgGrouperQuery,
            List<Domain.Yamed.KsgCalculation.KsgGrouper>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllKsgGrouperQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.KsgGrouper>> Handle(GetAllKsgGrouperQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.KsgGrouper
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
