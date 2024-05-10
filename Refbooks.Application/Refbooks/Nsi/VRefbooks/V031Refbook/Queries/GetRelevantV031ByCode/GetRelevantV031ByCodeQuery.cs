
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetRelevantV031ByCode
{
    public class GetRelevantV031ByCodeQuery : IRequest<V031>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
