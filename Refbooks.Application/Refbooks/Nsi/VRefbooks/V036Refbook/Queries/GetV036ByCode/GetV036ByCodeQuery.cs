
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetV036ByCode
{
    public class GetV036ByCodeQuery : IRequest<V036[]>
    {
        public string Code { get; set; }
    }
}
