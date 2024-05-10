
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V027Refbook.Queries.GetAllRelevantV027
{
    public class GetAllRelevantV027Query : IRequest<V027[]>
    {
        public DateTime Date { get; set; }
    }
}
