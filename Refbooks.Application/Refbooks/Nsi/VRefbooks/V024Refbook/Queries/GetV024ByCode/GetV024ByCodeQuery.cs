
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetV024ByCode
{
    public class GetV024ByCodeQuery : IRequest<V024[]>
    {
        public string Code { get; set; }
    }
}
