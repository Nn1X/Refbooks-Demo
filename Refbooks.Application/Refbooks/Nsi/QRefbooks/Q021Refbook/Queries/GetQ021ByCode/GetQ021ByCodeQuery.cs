
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetQ021ByCode
{
    public class GetQ021ByCodeQuery : IRequest<Q021[]>
    {
        public string Code { get; set; }
    }
}
