
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetRelevantV016ByCode
{
    public class GetRelevantV016ByCodeQuery : IRequest<V016>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
