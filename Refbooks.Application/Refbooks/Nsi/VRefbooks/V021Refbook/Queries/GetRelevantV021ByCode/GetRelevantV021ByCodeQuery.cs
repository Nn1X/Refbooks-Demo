
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetRelevantV021ByCode
{
    public class GetRelevantV021ByCodeQuery : IRequest<V021>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
