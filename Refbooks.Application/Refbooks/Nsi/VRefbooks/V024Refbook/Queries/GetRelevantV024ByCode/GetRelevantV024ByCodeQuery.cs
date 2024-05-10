
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetRelevantV024ByCode
{
    public class GetRelevantV024ByCodeQuery : IRequest<V024>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
