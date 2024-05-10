
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetAllRelevantR007
{
    public class GetAllRelevantR007Query : IRequest<R007[]>
    {
        public DateTime Date { get; set; }
    }
}
