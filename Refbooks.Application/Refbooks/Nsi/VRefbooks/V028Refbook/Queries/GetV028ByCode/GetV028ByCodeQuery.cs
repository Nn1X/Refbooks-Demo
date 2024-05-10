
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetV028ByCode
{
    public class GetV028ByCodeQuery : IRequest<V028[]>
    {
        public int Code { get; set; }
    }
}
