
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q020Refbook.Queries.GetQ020ByCode
{
    public class GetQ020ByCodeQuery : IRequest<Q020[]>
    {
        public string Code { get; set; }
    }
}
