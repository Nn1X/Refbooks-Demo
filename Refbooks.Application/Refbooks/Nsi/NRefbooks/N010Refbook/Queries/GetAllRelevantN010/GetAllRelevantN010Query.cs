
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N010Refbook.Queries.GetAllRelevantN010
{
    public class GetAllRelevantN010Query : IRequest<N010[]>
    {
        public DateTime Date { get; set; }
    }
}
