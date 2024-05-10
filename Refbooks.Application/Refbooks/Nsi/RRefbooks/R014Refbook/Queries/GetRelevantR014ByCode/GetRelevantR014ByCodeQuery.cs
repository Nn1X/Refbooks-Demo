
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetRelevantR014ByCode
{
    public class GetRelevantR014ByCodeQuery : IRequest<R014>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
