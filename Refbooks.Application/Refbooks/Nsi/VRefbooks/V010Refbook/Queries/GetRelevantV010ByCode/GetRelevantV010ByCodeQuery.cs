
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetRelevantV010ByCode
{
    public class GetRelevantV010ByCodeQuery : IRequest<V010>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
