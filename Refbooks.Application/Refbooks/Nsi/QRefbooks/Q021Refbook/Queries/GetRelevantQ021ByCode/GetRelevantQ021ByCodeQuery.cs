
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetRelevantQ021ByCode
{
    public class GetRelevantQ021ByCodeQuery : IRequest<Q021>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
