
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetV021ByCode
{
    public class GetV021ByCodeQuery : IRequest<V021[]>
    {
        public int Code { get; set; }
    }
}
