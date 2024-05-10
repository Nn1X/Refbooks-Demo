
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetRelevantN009ByCode
{
    public class GetRelevantN009ByCodeQuery : IRequest<N009>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
