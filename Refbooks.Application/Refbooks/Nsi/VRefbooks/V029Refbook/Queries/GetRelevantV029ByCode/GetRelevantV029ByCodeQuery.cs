
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetRelevantV029ByCode
{
    public class GetRelevantV029ByCodeQuery : IRequest<V029>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
