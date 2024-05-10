using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation.Queries.GetAll
{
    public class GetAllFirstStageAdultProfessionalExaminationCalculationQueryHandler
        : IRequestHandler<GetAllFirstStageAdultProfessionalExaminationCalculationQuery,
            List<Domain.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllFirstStageAdultProfessionalExaminationCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Domain.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation>> Handle(
            GetAllFirstStageAdultProfessionalExaminationCalculationQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.FirstStageAdultProfessionalExaminationCalculation
                    .ToListAsync();
            }
        }
    }
}
