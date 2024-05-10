
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetRelevantV019ByCode
{
    public class GetRelevantV019ByCodeQuery : IRequest<V019>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
