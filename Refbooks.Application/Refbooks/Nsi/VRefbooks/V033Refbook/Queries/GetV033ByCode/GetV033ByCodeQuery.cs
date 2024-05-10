
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetV033ByCode
{
    public class GetV033ByCodeQuery : IRequest<V033[]>
    {
        public string Code { get; set; }
    }
}
