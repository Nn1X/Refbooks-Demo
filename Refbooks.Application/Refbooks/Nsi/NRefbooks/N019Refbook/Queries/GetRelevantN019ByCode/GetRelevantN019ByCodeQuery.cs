
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetRelevantN019ByCode
{
    public class GetRelevantN019ByCodeQuery : IRequest<N019>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
