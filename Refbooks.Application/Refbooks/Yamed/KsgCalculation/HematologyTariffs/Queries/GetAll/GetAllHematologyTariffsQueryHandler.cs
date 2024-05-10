using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.HematologyTariffs.Queries.GetAll
{
    public class GetAllHematologyTariffsQueryHandler
        : IRequestHandler<GetAllHematologyTariffsQuery,
            List<Domain.Yamed.KsgCalculation.HematologyTariff>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllHematologyTariffsQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<HematologyTariff>> Handle(GetAllHematologyTariffsQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.HematologyTariffs
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
