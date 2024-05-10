
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetRelevantR007ByCode
{
    public class GetRelevantR007ByCodeQuery : IRequest<R007>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
