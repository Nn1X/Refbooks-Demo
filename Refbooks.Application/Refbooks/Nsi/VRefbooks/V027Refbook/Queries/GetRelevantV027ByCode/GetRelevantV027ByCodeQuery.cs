
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetRelevantV027ByCode
{
    public class GetRelevantV027ByCodeQuery : IRequest<V027>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
