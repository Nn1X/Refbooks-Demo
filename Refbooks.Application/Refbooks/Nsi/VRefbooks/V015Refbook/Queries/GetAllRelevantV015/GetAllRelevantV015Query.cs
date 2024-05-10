
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V015Refbook.Queries.GetAllRelevantV015
{
    public class GetAllRelevantV015Query : IRequest<V015[]>
    {
        public DateTime Date { get; set; }
    }
}
