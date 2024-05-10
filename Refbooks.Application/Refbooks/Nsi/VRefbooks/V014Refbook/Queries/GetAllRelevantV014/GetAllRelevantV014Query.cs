
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V014Refbook.Queries.GetAllRelevantV014
{
    public class GetAllRelevantV014Query : IRequest<V014[]>
    {
        public DateTime Date { get; set; }
    }
}
