
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetAllRelevantV028
{
    public class GetAllRelevantV028Query : IRequest<V028[]>
    {
        public DateTime Date { get; set; }
    }
}
