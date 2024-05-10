
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetQ016ByCode
{
    public class GetQ016ByCodeQuery : IRequest<Q016[]>
    {
        public string Code { get; set; }
    }
}
