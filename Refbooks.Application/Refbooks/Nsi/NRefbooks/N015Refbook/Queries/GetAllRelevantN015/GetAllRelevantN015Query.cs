
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N015Refbook.Queries.GetAllRelevantN015
{
    public class GetAllRelevantN015Query : IRequest<N015[]>
    {
        public DateTime Date { get; set; }
    }
}
