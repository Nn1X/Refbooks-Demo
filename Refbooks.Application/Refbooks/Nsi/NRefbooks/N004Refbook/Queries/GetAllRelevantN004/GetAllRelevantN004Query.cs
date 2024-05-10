
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetAllRelevantN004
{
    public class GetAllRelevantN004Query : IRequest<N004[]>
    {
        public DateTime Date { get; set; }
    }
}
