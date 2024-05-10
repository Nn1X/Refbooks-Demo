
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetAllRelevantN017
{
    public class GetAllRelevantN017Query : IRequest<N017[]>
    {
        public DateTime Date { get; set; }
    }
}
