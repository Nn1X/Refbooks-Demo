
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetQ019ByCode
{
    public class GetQ019ByCodeQuery : IRequest<Q019[]>
    {
        public string Code { get; set; }
    }
}
