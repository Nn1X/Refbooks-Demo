
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V022Refbook.Queries.GetAllRelevantV022
{
    public class GetAllRelevantV022Query : IRequest<V022[]>
    {
        public DateTime Date { get; set; }
    }
}
