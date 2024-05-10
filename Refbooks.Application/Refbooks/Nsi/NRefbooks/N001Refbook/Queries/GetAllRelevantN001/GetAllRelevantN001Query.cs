
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N001Refbook.Queries.GetAllRelevantN001
{
    public class GetAllRelevantN001Query : IRequest<N001[]>
    {
        public DateTime Date { get; set; }
    }
}
