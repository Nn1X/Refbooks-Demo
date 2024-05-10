using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.HighTechMedicalCareTariffs.Queries.GetAll
{
    public class GetAllHighTechMedicalCareTariffsQueryHandler
        : IRequestHandler<GetAllHighTechMedicalCareTariffsQuery,
            List<Domain.Yamed.KsgCalculation.HighTechMedicalCareTariff>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllHighTechMedicalCareTariffsQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<HighTechMedicalCareTariff>> Handle(GetAllHighTechMedicalCareTariffsQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.HighTechMedicalCareTariffs
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
