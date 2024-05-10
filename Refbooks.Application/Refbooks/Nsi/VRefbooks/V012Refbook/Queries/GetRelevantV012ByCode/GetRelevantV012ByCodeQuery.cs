
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetRelevantV012ByCode
{
    public class GetRelevantV012ByCodeQuery : IRequest<V012>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
