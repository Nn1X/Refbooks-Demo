
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetRelevantV002ByCode
{
    public class GetRelevantV002ByCodeQuery : IRequest<V002>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
