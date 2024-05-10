
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetAllRelevantR004
{
    public class GetAllRelevantR004Query : IRequest<R004[]>
    {
        public DateTime Date { get; set; }
    }
}
