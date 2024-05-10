
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V026Refbook.Queries.GetAllRelevantV026
{
    public class GetAllRelevantV026Query : IRequest<V026[]>
    {
        public DateTime Date { get; set; }
    }
}
