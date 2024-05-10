
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetRelevantR010ByCode
{
    public class GetRelevantR010ByCodeQuery : IRequest<R010>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
