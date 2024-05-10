
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetRelevantV026ByCode
{
    public class GetRelevantV026ByCodeQuery : IRequest<V026>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
