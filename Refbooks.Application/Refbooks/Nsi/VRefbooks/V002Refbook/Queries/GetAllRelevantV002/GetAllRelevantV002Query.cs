
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V002Refbook.Queries.GetAllRelevantV002
{
    public class GetAllRelevantV002Query : IRequest<V002[]>
    {
        public DateTime Date { get; set; }
    }
}
