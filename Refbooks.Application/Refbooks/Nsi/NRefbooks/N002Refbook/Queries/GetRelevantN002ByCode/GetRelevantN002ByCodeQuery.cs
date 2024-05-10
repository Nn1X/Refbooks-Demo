
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N002Refbook.Queries.GetRelevantN002ByCode
{
    public class GetRelevantN002ByCodeQuery : IRequest<N002>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
