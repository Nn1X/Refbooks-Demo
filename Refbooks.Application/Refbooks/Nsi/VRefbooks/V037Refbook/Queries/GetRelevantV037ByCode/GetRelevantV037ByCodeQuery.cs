
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetRelevantV037ByCode
{
    public class GetRelevantV037ByCodeQuery : IRequest<V037>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
