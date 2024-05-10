
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetV002ByCode
{
    public class GetV002ByCodeQuery : IRequest<V002[]>
    {
        public int Code { get; set; }
    }
}
