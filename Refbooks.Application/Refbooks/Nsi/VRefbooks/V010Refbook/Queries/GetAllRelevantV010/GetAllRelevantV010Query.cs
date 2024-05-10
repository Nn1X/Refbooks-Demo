
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V010Refbook.Queries.GetAllRelevantV010
{
    public class GetAllRelevantV010Query : IRequest<V010[]>
    {
        public DateTime Date { get; set; }
    }
}
