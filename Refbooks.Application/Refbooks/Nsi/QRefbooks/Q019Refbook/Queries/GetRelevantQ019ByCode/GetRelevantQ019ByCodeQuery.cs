
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetRelevantQ019ByCode
{
    public class GetRelevantQ019ByCodeQuery : IRequest<Q019>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
