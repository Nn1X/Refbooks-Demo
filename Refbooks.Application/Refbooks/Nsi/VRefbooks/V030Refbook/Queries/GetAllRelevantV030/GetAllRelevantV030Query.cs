
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V030Refbook.Queries.GetAllRelevantV030
{
    public class GetAllRelevantV030Query : IRequest<V030[]>
    {
        public DateTime Date { get; set; }
    }
}
