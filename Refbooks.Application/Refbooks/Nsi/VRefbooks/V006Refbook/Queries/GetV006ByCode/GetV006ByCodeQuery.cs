
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetV006ByCode
{
    public class GetV006ByCodeQuery : IRequest<V006[]>
    {
        public int Code { get; set; }
    }
}
