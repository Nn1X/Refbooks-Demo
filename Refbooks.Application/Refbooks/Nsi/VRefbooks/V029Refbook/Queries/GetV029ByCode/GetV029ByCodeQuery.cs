
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetV029ByCode
{
    public class GetV029ByCodeQuery : IRequest<V029[]>
    {
        public int Code { get; set; }
    }
}
