using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.KsgCalculation.Queries.GetAll
{
    public class GetAllKsgCalculationQueryHandler
        : IRequestHandler<GetAllKsgCalculationQuery,
            List<Domain.Yamed.KsgCalculation.KsgCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllKsgCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.KsgCalculation>> Handle(GetAllKsgCalculationQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.KsgCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
