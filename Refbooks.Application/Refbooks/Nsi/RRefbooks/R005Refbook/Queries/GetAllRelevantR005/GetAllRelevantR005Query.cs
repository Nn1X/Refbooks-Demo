
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetAllRelevantR005
{
    public class GetAllRelevantR005Query : IRequest<R005[]>
    {
        public DateTime Date { get; set; }
    }
}
