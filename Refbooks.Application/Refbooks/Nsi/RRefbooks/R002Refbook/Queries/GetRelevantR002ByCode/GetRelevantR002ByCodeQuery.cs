
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetRelevantR002ByCode
{
    public class GetRelevantR002ByCodeQuery : IRequest<R002>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
