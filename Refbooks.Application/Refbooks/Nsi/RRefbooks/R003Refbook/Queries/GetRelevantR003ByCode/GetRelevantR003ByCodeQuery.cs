
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetRelevantR003ByCode
{
    public class GetRelevantR003ByCodeQuery : IRequest<R003>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
