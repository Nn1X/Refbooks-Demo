
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V025Refbook.Queries.GetAllRelevantV025
{
    public class GetAllRelevantV025Query : IRequest<V025[]>
    {
        public DateTime Date { get; set; }
    }
}
