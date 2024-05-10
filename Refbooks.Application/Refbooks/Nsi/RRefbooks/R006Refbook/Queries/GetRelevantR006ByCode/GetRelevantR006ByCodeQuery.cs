
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetRelevantR006ByCode
{
    public class GetRelevantR006ByCodeQuery : IRequest<R006>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
