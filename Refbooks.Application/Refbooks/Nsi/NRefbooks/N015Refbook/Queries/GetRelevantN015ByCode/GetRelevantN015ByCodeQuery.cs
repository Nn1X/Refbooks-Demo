
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N015Refbook.Queries.GetRelevantN015ByCode
{
    public class GetRelevantN015ByCodeQuery : IRequest<N015>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
