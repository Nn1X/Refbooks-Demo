
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetV018ByCode
{
    public class GetV018ByCodeQuery : IRequest<V018[]>
    {
        public string Code { get; set; }
    }
}
