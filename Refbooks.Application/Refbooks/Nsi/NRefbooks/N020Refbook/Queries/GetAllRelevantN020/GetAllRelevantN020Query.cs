
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetAllRelevantN020
{
    public class GetAllRelevantN020Query : IRequest<N020[]>
    {
        public DateTime Date { get; set; }
    }
}
