
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetAllRelevantN016
{
    public class GetAllRelevantN016Query : IRequest<N016[]>
    {
        public DateTime Date { get; set; }
    }
}
