
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R011Refbook.Queries.GetR011ByCode
{
    public class GetR011ByCodeQuery : IRequest<R011[]>
    {
        public int Code { get; set; }
    }
}
