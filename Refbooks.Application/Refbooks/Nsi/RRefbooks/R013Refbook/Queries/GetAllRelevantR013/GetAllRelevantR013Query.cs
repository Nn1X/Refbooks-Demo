
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetAllRelevantR013
{
    public class GetAllRelevantR013Query : IRequest<R013[]>
    {
        public DateTime Date { get; set; }
    }
}
