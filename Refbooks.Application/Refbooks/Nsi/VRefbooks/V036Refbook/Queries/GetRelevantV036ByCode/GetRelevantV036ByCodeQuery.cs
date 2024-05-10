
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetRelevantV036ByCode
{
    public class GetRelevantV036ByCodeQuery : IRequest<V036>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
