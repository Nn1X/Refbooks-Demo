
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetV030ByCode
{
    public class GetV030ByCodeQuery : IRequest<V030[]>
    {
        public string Code { get; set; }
    }
}
