
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetAllRelevantV020
{
    public class GetAllRelevantV020Query : IRequest<V020[]>
    {
        public DateTime Date { get; set; }
    }
}
