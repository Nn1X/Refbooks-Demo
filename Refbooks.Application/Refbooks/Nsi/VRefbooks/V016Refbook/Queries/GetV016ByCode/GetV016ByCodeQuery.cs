
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetV016ByCode
{
    public class GetV016ByCodeQuery : IRequest<V016[]>
    {
        public string Code { get; set; }
    }
}
