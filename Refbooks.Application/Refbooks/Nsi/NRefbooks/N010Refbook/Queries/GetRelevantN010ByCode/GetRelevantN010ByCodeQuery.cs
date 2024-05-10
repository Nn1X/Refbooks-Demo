
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N010Refbook.Queries.GetRelevantN010ByCode
{
    public class GetRelevantN010ByCodeQuery : IRequest<N010>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
