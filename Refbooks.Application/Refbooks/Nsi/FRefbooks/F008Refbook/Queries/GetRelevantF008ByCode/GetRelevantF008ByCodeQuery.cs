using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetRelevantF008ByCode
{
    public class GetRelevantF008ByCodeQuery : IRequest<F008>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
