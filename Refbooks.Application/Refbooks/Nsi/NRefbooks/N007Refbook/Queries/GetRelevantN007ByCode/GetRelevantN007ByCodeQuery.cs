
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetRelevantN007ByCode
{
    public class GetRelevantN007ByCodeQuery : IRequest<N007>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
