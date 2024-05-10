
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetAllRelevantF042
{
    public class GetAllRelevantF042Query : IRequest<F042[]>
    {
        public DateTime Date { get; set; }
    }
}
