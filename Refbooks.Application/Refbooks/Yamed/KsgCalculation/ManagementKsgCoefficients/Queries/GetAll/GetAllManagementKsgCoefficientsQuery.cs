using MediatR;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.ManagementKsgCoefficients.Queries.GetAll
{
    public class GetAllManagementKsgCoefficientsQuery
        : IRequest<List<Domain.Yamed.KsgCalculation.ManagementKsgCoefficient>>
    {
    }
}
