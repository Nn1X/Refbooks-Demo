
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetRelevantV030ByCode
{
    public class GetRelevantV030ByCodeQuery : IRequest<V030>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
