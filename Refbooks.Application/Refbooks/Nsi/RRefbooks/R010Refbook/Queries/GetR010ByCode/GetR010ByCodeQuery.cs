
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R010Refbook.Queries.GetR010ByCode
{
    public class GetR010ByCodeQuery : IRequest<R010[]>
    {
        public int Code { get; set; }
    }
}
