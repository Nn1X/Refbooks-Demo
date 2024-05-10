using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.MobileTeamsMedicalExaminationCoefficients.Queries.GetAll
{
    public class GetAllMobileTeamsMedicalExaminationCoefficientsQuery
        : IRequest<List<Domain.Yamed.KsgCalculation.MobileTeamsMedicalExaminationCoefficient>>
    {
    }
}
