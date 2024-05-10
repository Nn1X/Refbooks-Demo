
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V006Refbook.Queries.GetAllRelevantV006
{
    public class GetAllRelevantV006Query : IRequest<V006[]>
    {
        public DateTime Date { get; set; }
    }
}
