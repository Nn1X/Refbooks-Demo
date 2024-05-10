
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetRelevantV006ByCode
{
    public class GetRelevantV006ByCodeQuery : IRequest<V006>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
