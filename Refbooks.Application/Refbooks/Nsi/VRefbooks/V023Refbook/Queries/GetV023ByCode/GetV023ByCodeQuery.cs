
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetV023ByCode
{
    public class GetV023ByCodeQuery : IRequest<V023[]>
    {
        public int Code { get; set; }
    }
}
