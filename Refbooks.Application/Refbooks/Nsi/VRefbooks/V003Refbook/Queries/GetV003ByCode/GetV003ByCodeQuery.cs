
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetV003ByCode
{
    public class GetV003ByCodeQuery : IRequest<V003[]>
    {
        public int Code { get; set; }
    }
}
