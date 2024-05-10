
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetAllRelevantN007
{
    public class GetAllRelevantN007Query : IRequest<N007[]>
    {
        public DateTime Date { get; set; }
    }
}
