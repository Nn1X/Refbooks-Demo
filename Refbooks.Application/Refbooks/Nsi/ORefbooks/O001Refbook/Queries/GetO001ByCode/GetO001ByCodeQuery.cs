
using MediatR;
using Refbooks.Domain.Nsi.ORefbooks;
namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O001Refbook.Queries.GetO001ByCode
{
    public class GetO001ByCodeQuery : IRequest<O001>
    {
        public string Code { get; set; }
    }
}
