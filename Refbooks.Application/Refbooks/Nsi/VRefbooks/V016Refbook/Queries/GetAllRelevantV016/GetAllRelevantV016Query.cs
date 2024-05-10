
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V016Refbook.Queries.GetAllRelevantV016
{
    public class GetAllRelevantV016Query : IRequest<V016[]>
    {
        public DateTime Date { get; set; }
    }
}
