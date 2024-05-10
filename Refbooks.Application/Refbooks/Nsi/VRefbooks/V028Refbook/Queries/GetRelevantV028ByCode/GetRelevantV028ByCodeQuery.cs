
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetRelevantV028ByCode
{
    public class GetRelevantV028ByCodeQuery : IRequest<V028>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
