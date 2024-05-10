
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetQ018ByCode
{
    public class GetQ018ByCodeQuery : IRequest<Q018[]>
    {
        public string Code { get; set; }
    }
}
