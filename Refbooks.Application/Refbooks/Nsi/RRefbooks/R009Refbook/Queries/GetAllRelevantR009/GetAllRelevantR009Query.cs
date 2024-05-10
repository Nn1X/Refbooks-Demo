
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetAllRelevantR009
{
    public class GetAllRelevantR009Query : IRequest<R009[]>
    {
        public DateTime Date { get; set; }
    }
}
