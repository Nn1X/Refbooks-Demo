
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetAllRelevantR006
{
    public class GetAllRelevantR006Query : IRequest<R006[]>
    {
        public DateTime Date { get; set; }
    }
}
