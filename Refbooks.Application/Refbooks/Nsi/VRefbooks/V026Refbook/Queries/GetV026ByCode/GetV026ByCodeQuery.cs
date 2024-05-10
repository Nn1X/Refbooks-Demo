
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetV026ByCode
{
    public class GetV026ByCodeQuery : IRequest<V026[]>
    {
        public int Code { get; set; }
    }
}
