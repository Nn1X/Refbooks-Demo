
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetRelevantR013ByCode
{
    public class GetRelevantR013ByCodeQuery : IRequest<R013>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
