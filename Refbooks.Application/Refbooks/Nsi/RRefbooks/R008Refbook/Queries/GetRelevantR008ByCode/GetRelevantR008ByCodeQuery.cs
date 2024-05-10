
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetRelevantR008ByCode
{
    public class GetRelevantR008ByCodeQuery : IRequest<R008>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
