
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetV032ByCode
{
    public class GetV032ByCodeQuery : IRequest<V032[]>
    {
        public string Code { get; set; }
    }
}
