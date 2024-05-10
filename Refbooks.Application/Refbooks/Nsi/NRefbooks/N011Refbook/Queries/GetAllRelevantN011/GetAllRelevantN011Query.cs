
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetAllRelevantN011
{
    public class GetAllRelevantN011Query : IRequest<N011[]>
    {
        public DateTime Date { get; set; }
    }
}
