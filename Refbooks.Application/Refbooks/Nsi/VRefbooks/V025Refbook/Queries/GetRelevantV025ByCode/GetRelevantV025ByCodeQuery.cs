
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetRelevantV025ByCode
{
    public class GetRelevantV025ByCodeQuery : IRequest<V025>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
