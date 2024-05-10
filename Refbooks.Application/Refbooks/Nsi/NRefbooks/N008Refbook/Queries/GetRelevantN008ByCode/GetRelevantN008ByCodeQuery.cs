
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N008Refbook.Queries.GetRelevantN008ByCode
{
    public class GetRelevantN008ByCodeQuery : IRequest<N008>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
