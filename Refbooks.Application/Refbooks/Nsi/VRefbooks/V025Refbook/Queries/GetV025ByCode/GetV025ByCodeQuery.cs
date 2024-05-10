
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetV025ByCode
{
    public class GetV025ByCodeQuery : IRequest<V025[]>
    {
        public string Code { get; set; }
    }
}
