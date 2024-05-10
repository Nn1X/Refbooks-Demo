
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetV020ByCode
{
    public class GetV020ByCodeQuery : IRequest<V020[]>
    {
        public int Code { get; set; }
    }
}
