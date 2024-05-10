using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.RegionalLaboratoryStudiesCalculation.Queries.GetAll
{
    public class GetAllRegionalLaboratoryStudiesCalculationQueryHandler
         : IRequestHandler<GetAllRegionalLaboratoryStudiesCalculationQuery,
            List<Domain.Yamed.KsgCalculation.RegionalLaboratoryStudiesCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRegionalLaboratoryStudiesCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.RegionalLaboratoryStudiesCalculation>> Handle(
            GetAllRegionalLaboratoryStudiesCalculationQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.RegionalLaboratoryStudiesCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
