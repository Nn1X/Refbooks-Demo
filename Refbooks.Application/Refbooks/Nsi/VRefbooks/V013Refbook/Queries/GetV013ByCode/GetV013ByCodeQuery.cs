
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetV013ByCode
{
    public class GetV013ByCodeQuery : IRequest<V013[]>
    {
        public int Code { get; set; }
    }
}
