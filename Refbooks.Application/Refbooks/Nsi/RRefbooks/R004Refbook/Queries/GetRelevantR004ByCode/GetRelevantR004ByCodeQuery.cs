
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetRelevantR004ByCode
{
    public class GetRelevantR004ByCodeQuery : IRequest<R004>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
