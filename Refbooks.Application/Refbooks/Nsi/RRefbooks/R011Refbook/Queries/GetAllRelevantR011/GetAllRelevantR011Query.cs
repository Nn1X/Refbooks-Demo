
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetAllRelevantR011
{
    public class GetAllRelevantR011Query : IRequest<R011[]>
    {
        public DateTime Date { get; set; }
    }
}
