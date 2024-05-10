
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetAllRelevantR003
{
    public class GetAllRelevantR003Query : IRequest<R003[]>
    {
        public DateTime Date { get; set; }
    }
}
