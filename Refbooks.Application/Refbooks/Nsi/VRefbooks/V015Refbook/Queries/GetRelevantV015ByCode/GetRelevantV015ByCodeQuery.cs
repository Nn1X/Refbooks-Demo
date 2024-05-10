
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetRelevantV015ByCode
{
    public class GetRelevantV015ByCodeQuery : IRequest<V015>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
