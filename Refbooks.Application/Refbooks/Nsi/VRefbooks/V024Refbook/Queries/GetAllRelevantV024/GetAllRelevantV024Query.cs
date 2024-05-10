
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V024Refbook.Queries.GetAllRelevantV024
{
    public class GetAllRelevantV024Query : IRequest<V024[]>
    {
        public DateTime Date { get; set; }
    }
}
