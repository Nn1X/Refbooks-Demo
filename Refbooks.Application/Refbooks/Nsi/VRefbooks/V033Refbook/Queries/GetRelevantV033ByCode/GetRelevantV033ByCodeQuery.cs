
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetRelevantV033ByCode
{
    public class GetRelevantV033ByCodeQuery : IRequest<V033>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
