
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R014Refbook.Queries.GetR014ByCode
{
    public class GetR014ByCodeQuery : IRequest<R014[]>
    {
        public int Code { get; set; }
    }
}
