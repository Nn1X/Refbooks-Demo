using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.OutpatientTariffCalculation.Queries.GetAll
{
    public class GetAllOutpatientTariffCalculationQuery
    : IRequest<List<Domain.Yamed.KsgCalculation.OutpatientTariffCalculation>>
    {
    }
}
