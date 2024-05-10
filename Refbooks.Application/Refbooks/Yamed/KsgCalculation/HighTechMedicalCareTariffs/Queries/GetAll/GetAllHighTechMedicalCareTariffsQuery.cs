using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.HighTechMedicalCareTariffs.Queries.GetAll
{
    public class GetAllHighTechMedicalCareTariffsQuery
    : IRequest<List<Domain.Yamed.KsgCalculation.HighTechMedicalCareTariff>>
    {
    }
}
