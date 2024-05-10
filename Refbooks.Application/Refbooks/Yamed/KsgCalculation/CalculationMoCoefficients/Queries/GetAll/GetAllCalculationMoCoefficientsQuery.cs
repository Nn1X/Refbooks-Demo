using MediatR;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.CalculationMoCoefficients.Queries.GetAll
{
    public class GetAllCalculationMoCoefficientsQuery
        : IRequest<List<CalculationMoCoefficient>>
    {
    }
}
