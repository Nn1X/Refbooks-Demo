
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetV027ByCode
{
    public class GetV027ByCodeQuery : IRequest<V027[]>
    {
        public int Code { get; set; }
    }
}
