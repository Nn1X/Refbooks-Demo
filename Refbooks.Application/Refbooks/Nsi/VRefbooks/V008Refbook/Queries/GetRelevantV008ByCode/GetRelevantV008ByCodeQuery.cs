
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetRelevantV008ByCode
{
    public class GetRelevantV008ByCodeQuery : IRequest<V008>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
