
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetV008ByCode
{
    public class GetV008ByCodeQuery : IRequest<V008[]>
    {
        public int Code { get; set; }
    }
}
