
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetAllRelevantV017
{
    public class GetAllRelevantV017Query : IRequest<V017[]>
    {
        public DateTime Date { get; set; }
    }
}
