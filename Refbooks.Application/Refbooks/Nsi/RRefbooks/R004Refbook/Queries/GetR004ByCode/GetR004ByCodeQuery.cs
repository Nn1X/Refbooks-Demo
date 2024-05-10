
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetR004ByCode
{
    public class GetR004ByCodeQuery : IRequest<R004[]>
    {
        public int Code { get; set; }
    }
}
