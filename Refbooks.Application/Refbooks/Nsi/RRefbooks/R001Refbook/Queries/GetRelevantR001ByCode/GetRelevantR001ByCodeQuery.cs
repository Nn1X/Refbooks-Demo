
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetRelevantR001ByCode
{
    public class GetRelevantR001ByCodeQuery : IRequest<R001>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
