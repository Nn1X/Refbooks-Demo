
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetAllRelevantN003
{
    public class GetAllRelevantN003Query : IRequest<N003[]>
    {
        public DateTime Date { get; set; }
    }
}
