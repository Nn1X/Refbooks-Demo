
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetRelevantV003ByCode
{
    public class GetRelevantV003ByCodeQuery : IRequest<V003>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
