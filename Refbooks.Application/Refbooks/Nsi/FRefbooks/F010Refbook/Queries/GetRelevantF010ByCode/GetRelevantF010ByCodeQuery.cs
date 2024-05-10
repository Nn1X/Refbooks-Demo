using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetRelevantF010ByCode
{
    public class GetRelevantF010ByCodeQuery : IRequest<F010>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
