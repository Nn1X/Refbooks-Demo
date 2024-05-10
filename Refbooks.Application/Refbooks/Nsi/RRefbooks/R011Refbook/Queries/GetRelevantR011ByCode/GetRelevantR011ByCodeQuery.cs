
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetRelevantR011ByCode
{
    public class GetRelevantR011ByCodeQuery : IRequest<R011>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
