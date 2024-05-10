
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V023Refbook.Queries.GetAllRelevantV023
{
    public class GetAllRelevantV023Query : IRequest<V023[]>
    {
        public DateTime Date { get; set; }
    }
}
