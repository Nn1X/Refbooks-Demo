
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetAllRelevantN019
{
    public class GetAllRelevantN019Query : IRequest<N019[]>
    {
        public DateTime Date { get; set; }
    }
}
