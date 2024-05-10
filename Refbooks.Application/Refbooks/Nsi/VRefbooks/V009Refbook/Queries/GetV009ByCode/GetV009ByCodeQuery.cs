
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetV009ByCode
{
    public class GetV009ByCodeQuery : IRequest<V009[]>
    {
        public int Code { get; set; }
    }
}
