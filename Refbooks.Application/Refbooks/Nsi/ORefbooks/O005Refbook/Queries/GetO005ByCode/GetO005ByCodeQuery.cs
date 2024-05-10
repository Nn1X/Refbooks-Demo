
using MediatR;
using Refbooks.Domain.Nsi.ORefbooks;
namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O005Refbook.Queries.GetO005ByCode
{
    public class GetO005ByCodeQuery : IRequest<O005>
    {
        public int Code { get; set; }
    }
}
