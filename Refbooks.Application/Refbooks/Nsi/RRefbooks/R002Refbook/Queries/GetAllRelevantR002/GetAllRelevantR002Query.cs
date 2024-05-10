
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetAllRelevantR002
{
    public class GetAllRelevantR002Query : IRequest<R002[]>
    {
        public DateTime Date { get; set; }
    }
}
