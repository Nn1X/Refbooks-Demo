
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetQ017ByCode
{
    public class GetQ017ByCodeQuery : IRequest<Q017[]>
    {
        public string Code { get; set; }
    }
}
