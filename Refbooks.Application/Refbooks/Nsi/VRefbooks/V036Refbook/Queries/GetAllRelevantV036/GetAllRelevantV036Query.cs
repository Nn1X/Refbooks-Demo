
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V036Refbook.Queries.GetAllRelevantV036
{
    public class GetAllRelevantV036Query : IRequest<V036[]>
    {
        public DateTime Date { get; set; }
    }
}
