
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetRelevantV023ByCode
{
    public class GetRelevantV023ByCodeQuery : IRequest<V023>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
