
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetRelevantV014ByCode
{
    public class GetRelevantV014ByCodeQuery : IRequest<V014>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
