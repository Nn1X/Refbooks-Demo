
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V008Refbook.Queries.GetAllRelevantV008
{
    public class GetAllRelevantV008Query : IRequest<V008[]>
    {
        public DateTime Date { get; set; }
    }
}
