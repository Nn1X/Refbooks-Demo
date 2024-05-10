using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.FirstStageAdultMedicalExaminationCalculation.Queries.GetAll
{
    public class GetAllFirstStageAdultMedicalExaminationCalculationQuery
        : IRequest<List<Domain.Yamed.KsgCalculation.FirstStageAdultProfessionalExaminationCalculation>>
    {
    }
}
