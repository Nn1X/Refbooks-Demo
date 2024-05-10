
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N002Refbook.Queries.GetAllRelevantN002
{
    public class GetAllRelevantN002Query : IRequest<N002[]>
    {
        public DateTime Date { get; set; }
    }
}
