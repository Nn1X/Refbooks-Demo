
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetAllRelevantN012
{
    public class GetAllRelevantN012Query : IRequest<N012[]>
    {
        public DateTime Date { get; set; }
    }
}
