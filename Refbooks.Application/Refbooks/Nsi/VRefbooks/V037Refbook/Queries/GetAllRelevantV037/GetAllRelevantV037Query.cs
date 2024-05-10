
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V037Refbook.Queries.GetAllRelevantV037
{
    public class GetAllRelevantV037Query : IRequest<V037[]>
    {
        public DateTime Date { get; set; }
    }
}
