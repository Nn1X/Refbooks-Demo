
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q022Refbook.Queries.GetQ022ByCode
{
    public class GetQ022ByCodeQuery : IRequest<Q022[]>
    {
        public string Code { get; set; }
    }
}
