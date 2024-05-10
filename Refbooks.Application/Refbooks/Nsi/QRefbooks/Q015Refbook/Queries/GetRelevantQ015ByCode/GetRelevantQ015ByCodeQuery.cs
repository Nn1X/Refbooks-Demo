
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetRelevantQ015ByCode
{
    public class GetRelevantQ015ByCodeQuery : IRequest<Q015>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
