
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetRelevantV013ByCode
{
    public class GetRelevantV013ByCodeQuery : IRequest<V013>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
