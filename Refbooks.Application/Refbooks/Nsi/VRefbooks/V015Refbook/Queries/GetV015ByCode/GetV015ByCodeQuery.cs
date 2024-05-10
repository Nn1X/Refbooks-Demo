
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetV015ByCode
{
    public class GetV015ByCodeQuery : IRequest<V015[]>
    {
        public int Code { get; set; }
    }
}
