
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V029Refbook.Queries.GetAllRelevantV029
{
    public class GetAllRelevantV029Query : IRequest<V029[]>
    {
        public DateTime Date { get; set; }
    }
}
