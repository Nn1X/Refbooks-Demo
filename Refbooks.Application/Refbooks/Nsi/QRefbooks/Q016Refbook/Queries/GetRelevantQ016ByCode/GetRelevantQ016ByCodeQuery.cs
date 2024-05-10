
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetRelevantQ016ByCode
{
    public class GetRelevantQ016ByCodeQuery : IRequest<Q016>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
