using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.KsgBaseRates.Queries.GetAll
{
    public class GetAllKsgBaseRatesQueryHandler
        : IRequestHandler<GetAllKsgBaseRatesQuery,
            List<Domain.Yamed.KsgCalculation.KsgBaseRate>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllKsgBaseRatesQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<KsgBaseRate>> Handle(GetAllKsgBaseRatesQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.KsgBaseRates
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
