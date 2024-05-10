
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V019Refbook.Queries.GetAllRelevantV019
{
    public class GetAllRelevantV019Query : IRequest<V019[]>
    {
        public DateTime Date { get; set; }
    }
}
