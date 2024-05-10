
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetAllRelevantR010
{
    public class GetAllRelevantR010Query : IRequest<R010[]>
    {
        public DateTime Date { get; set; }
    }
}
