
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetQ015ByCode
{
    public class GetQ015ByCodeQuery : IRequest<Q015[]>
    {
        public string Code { get; set; }
    }
}
