
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V009Refbook.Queries.GetAllRelevantV009
{
    public class GetAllRelevantV009Query : IRequest<V009[]>
    {
        public DateTime Date { get; set; }
    }
}
