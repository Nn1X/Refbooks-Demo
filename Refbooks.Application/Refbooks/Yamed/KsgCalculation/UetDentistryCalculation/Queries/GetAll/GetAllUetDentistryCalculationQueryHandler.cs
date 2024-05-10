using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.UetDentistryCalculation.Queries.GetAll
{
    public class GetAllUetDentistryCalculationQueryHandler
        : IRequestHandler<GetAllUetDentistryCalculationQuery,
            List<Domain.Yamed.KsgCalculation.UetDentistryCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllUetDentistryCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.UetDentistryCalculation>> Handle(GetAllUetDentistryCalculationQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.UetDentistryCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
