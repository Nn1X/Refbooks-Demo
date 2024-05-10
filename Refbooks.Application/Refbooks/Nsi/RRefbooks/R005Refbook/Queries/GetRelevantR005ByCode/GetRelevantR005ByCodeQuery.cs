
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetRelevantR005ByCode
{
    public class GetRelevantR005ByCodeQuery : IRequest<R005>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
