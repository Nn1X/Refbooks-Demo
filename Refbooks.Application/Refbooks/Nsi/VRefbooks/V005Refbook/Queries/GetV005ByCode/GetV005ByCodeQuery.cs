
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V005Refbook.Queries.GetV005ByCode
{
    public class GetV005ByCodeQuery : IRequest<V005>
    {
        public int Code { get; set; }
    }
}
