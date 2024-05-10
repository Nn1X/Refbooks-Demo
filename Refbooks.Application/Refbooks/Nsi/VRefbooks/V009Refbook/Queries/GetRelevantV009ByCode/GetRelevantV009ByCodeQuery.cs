
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetRelevantV009ByCode
{
    public class GetRelevantV009ByCodeQuery : IRequest<V009>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
