
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetV017ByCode
{
    public class GetV017ByCodeQuery : IRequest<V017[]>
    {
        public int Code { get; set; }
    }
}
