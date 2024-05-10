
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetAllRelevantV003
{
    public class GetAllRelevantV003Query : IRequest<V003[]>
    {
        public DateTime Date { get; set; }
    }
}
