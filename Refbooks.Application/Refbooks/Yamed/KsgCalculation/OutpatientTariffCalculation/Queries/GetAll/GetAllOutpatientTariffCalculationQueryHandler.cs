using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.OutpatientTariffCalculation.Queries.GetAll
{
    public class GetAllOutpatientTariffCalculationQueryHandler
        : IRequestHandler<GetAllOutpatientTariffCalculationQuery,
            List<Domain.Yamed.KsgCalculation.OutpatientTariffCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllOutpatientTariffCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.OutpatientTariffCalculation>> Handle(
            GetAllOutpatientTariffCalculationQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.OutpatientTariffCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
