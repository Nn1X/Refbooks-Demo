using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.RegionalServiceTariffs.Queries.GetAll
{
    public class GetAllRegionalServiceTariffsQueryHandler
         : IRequestHandler<GetAllRegionalServiceTariffsQuery,
            List<Domain.Yamed.KsgCalculation.RegionalServiceTariff>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllRegionalServiceTariffsQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<RegionalServiceTariff>> Handle(GetAllRegionalServiceTariffsQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.RegionalServiceTariffs
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
