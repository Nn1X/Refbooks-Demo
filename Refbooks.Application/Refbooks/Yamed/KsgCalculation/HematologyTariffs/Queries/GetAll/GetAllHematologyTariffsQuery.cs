using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.HematologyTariffs.Queries.GetAll
{
    public class GetAllHematologyTariffsQuery
        : IRequest<List<Domain.Yamed.KsgCalculation.HematologyTariff>>
    {
    }
}
