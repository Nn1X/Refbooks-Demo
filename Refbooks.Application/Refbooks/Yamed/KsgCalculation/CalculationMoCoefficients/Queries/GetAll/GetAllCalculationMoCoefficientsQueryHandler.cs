using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.CalculationMoCoefficients.Queries.GetAll
{
    public class GetAllCalculationMoCoefficientsQueryHandler
        : IRequestHandler<GetAllCalculationMoCoefficientsQuery, List<CalculationMoCoefficient>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllCalculationMoCoefficientsQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<CalculationMoCoefficient>> Handle(GetAllCalculationMoCoefficientsQuery request,
            CancellationToken cancellationToken)
        {
            using(var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.CalculationMoCoefficients
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
