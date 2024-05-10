
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetV019ByCode
{
    public class GetV019ByCodeQuery : IRequest<V019[]>
    {
        public int Code { get; set; }
    }
}
