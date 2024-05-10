
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V033Refbook.Queries.GetAllRelevantV033
{
    public class GetAllRelevantV033Query : IRequest<V033[]>
    {
        public DateTime Date { get; set; }
    }
}
