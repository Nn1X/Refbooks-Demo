
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V032Refbook.Queries.GetAllRelevantV032
{
    public class GetAllRelevantV032Query : IRequest<V032[]>
    {
        public DateTime Date { get; set; }
    }
}
