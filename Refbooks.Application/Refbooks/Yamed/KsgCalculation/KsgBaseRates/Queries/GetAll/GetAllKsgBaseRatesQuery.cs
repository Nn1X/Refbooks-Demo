using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.KsgBaseRates.Queries.GetAll
{
    public class GetAllKsgBaseRatesQuery
    : IRequest<List<Domain.Yamed.KsgCalculation.KsgBaseRate>>
    {
    }
}
