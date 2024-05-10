
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetAllRelevantR014
{
    public class GetAllRelevantR014Query : IRequest<R014[]>
    {
        public DateTime Date { get; set; }
    }
}
