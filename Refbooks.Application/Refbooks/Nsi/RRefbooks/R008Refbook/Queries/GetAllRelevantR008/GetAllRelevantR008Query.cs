
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetAllRelevantR008
{
    public class GetAllRelevantR008Query : IRequest<R008[]>
    {
        public DateTime Date { get; set; }
    }
}
