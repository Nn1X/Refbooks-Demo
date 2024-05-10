
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetR013ByCode
{
    public class GetR013ByCodeQuery : IRequest<R013[]>
    {
        public int Code { get; set; }
    }
}
