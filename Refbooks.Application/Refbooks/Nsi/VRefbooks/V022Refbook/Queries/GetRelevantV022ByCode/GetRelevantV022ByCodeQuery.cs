
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetRelevantV022ByCode
{
    public class GetRelevantV022ByCodeQuery : IRequest<V022>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
