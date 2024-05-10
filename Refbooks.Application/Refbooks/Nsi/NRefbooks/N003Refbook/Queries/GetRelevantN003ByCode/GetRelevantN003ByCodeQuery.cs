
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetRelevantN003ByCode
{
    public class GetRelevantN003ByCodeQuery : IRequest<N003>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
