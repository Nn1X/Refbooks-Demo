
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetRelevantV032ByCode
{
    public class GetRelevantV032ByCodeQuery : IRequest<V032>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
