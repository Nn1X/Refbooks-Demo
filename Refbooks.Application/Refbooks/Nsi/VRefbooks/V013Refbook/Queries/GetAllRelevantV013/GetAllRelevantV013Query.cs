
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V013Refbook.Queries.GetAllRelevantV013
{
    public class GetAllRelevantV013Query : IRequest<V013[]>
    {
        public DateTime Date { get; set; }
    }
}
