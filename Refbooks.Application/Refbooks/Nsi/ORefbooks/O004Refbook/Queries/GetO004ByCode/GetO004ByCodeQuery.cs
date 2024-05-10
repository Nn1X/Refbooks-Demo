
using MediatR;
using Refbooks.Domain.Nsi.ORefbooks;
namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O004Refbook.Queries.GetO004ByCode
{
    public class GetO004ByCodeQuery : IRequest<O004[]>
    {
        public int Code { get; set; }
    }
}
