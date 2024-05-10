
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetRelevantN016ByCode
{
    public class GetRelevantN016ByCodeQuery : IRequest<N016>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
