
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V017Refbook.Queries.GetRelevantV017ByCode
{
    public class GetRelevantV017ByCodeQuery : IRequest<V017>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
