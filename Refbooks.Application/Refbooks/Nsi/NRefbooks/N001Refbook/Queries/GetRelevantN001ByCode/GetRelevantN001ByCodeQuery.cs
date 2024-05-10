
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N001Refbook.Queries.GetRelevantN001ByCode
{
    public class GetRelevantN001ByCodeQuery : IRequest<N001>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
