
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetRelevantF042ByCode
{
    public class GetRelevantF042ByCodeQuery : IRequest<F042>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
