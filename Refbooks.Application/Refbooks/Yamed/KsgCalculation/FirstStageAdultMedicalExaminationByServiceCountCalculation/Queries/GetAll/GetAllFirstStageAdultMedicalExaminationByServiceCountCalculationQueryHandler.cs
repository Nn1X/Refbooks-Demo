using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationByServiceCountCalculation.Queries.GetAll
{
    public class GetAllFirstStageAdultMedicalExaminationByServiceCountCalculationQueryHandler
        : IRequestHandler<GetAllFirstStageAdultMedicalExaminationByServiceCountCalculationQuery,
            List<Domain.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationByServiceCountCalculation>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllFirstStageAdultMedicalExaminationByServiceCountCalculationQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Domain.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationByServiceCountCalculation>> Handle(GetAllFirstStageAdultMedicalExaminationByServiceCountCalculationQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.FirstStageAdultMedicalExaminationByServiceCountCalculation
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
