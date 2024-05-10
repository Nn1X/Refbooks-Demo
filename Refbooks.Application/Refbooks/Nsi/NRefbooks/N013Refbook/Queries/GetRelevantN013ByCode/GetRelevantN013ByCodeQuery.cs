
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetRelevantN013ByCode
{
    public class GetRelevantN013ByCodeQuery : IRequest<N013>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
