
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetR001ByCode
{
    public class GetR001ByCodeQuery : IRequest<R001[]>
    {
        public string Code { get; set; }
    }
}
