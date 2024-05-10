
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetAllRelevantN005
{
    public class GetAllRelevantN005Query : IRequest<N005[]>
    {
        public DateTime Date { get; set; }
    }
}
