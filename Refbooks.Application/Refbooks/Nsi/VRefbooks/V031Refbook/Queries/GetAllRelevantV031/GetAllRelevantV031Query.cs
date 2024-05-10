
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V031Refbook.Queries.GetAllRelevantV031
{
    public class GetAllRelevantV031Query : IRequest<V031[]>
    {
        public DateTime Date { get; set; }
    }
}
