
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetV014ByCode
{
    public class GetV014ByCodeQuery : IRequest<V014[]>
    {
        public int Code { get; set; }
    }
}
