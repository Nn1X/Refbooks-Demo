using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationCalculation.Queries.GetAll
{
    public class GetAllFirstStageAdultMedicalExaminationCalculationQueryHandler
        : IRequestHandler<GetAllFirstStageAdultMedicalExaminationCalculationQuery,
            List<Domain.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllFirstStageAdultMedicalExaminationCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation>> Handle(GetAllFirstStageAdultMedicalExaminationCalculationQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.FirstStageAdultProfessionalExaminationCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
