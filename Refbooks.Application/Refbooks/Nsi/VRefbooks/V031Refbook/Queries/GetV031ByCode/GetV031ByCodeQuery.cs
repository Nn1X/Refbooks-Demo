
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetV031ByCode
{
    public class GetV031ByCodeQuery : IRequest<V031[]>
    {
        public int Code { get; set; }
    }
}
