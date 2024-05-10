
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetRelevantR012ByCode
{
    public class GetRelevantR012ByCodeQuery : IRequest<R012>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
