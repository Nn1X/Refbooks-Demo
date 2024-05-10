
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F032Refbook.Queries.GetRelevantF032ByCode
{
    public class GetRelevantF032ByCodeQuery : IRequest<F032>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
