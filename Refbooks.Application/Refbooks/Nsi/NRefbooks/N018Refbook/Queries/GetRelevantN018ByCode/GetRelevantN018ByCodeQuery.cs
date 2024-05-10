
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N018Refbook.Queries.GetRelevantN018ByCode
{
    public class GetRelevantN018ByCodeQuery : IRequest<N018>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
