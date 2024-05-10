
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetAllRelevantN013
{
    public class GetAllRelevantN013Query : IRequest<N013[]>
    {
        public DateTime Date { get; set; }
    }
}
