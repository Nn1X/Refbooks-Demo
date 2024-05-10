
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetRelevantN006ByCode
{
    public class GetRelevantN006ByCodeQuery : IRequest<N006>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
