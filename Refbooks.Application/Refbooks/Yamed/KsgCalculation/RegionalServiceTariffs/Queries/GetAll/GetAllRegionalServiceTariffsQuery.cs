using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.RegionalServiceTariffs.Queries.GetAll
{
    public class GetAllRegionalServiceTariffsQuery
    : IRequest<List<Domain.Yamed.KsgCalculation.RegionalServiceTariff>>
    {
    }
}
