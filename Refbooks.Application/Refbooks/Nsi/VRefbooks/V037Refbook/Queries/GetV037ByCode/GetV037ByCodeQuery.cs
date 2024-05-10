
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetV037ByCode
{
    public class GetV037ByCodeQuery : IRequest<V037[]>
    {
        public int Code { get; set; }
    }
}
