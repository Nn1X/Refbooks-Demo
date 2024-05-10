
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetAllRelevantN014
{
    public class GetAllRelevantN014Query : IRequest<N014[]>
    {
        public DateTime Date { get; set; }
    }
}
