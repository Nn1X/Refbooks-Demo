
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetRelevantR009ByCode
{
    public class GetRelevantR009ByCodeQuery : IRequest<R009>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
