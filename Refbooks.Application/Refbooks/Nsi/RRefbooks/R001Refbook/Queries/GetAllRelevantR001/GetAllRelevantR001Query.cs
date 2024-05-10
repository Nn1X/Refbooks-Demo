
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetAllRelevantR001
{
    public class GetAllRelevantR001Query : IRequest<R001[]>
    {
        public DateTime Date { get; set; }
    }
}
