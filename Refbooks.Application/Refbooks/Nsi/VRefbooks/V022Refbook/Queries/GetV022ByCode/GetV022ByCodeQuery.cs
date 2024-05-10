
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetV022ByCode
{
    public class GetV022ByCodeQuery : IRequest<V022[]>
    {
        public int Code { get; set; }
    }
}
