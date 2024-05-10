
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetRelevantV018ByCode
{
    public class GetRelevantV018ByCodeQuery : IRequest<V018>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
