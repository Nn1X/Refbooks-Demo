
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetQ023ByCode
{
    public class GetQ023ByCodeQuery : IRequest<Q023[]>
    {
        public string Code { get; set; }
    }
}
