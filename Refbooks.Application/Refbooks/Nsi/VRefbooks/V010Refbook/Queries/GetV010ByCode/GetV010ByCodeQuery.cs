
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetV010ByCode
{
    public class GetV010ByCodeQuery : IRequest<V010[]>
    {
        public int Code { get; set; }
    }
}
