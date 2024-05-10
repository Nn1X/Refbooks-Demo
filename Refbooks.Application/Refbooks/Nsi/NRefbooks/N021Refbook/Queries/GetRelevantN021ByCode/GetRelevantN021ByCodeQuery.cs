
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetRelevantN021ByCode
{
    public class GetRelevantN021ByCodeQuery : IRequest<N021>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
