
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V020Refbook.Queries.GetRelevantV020ByCode
{
    public class GetRelevantV020ByCodeQuery : IRequest<V020>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
