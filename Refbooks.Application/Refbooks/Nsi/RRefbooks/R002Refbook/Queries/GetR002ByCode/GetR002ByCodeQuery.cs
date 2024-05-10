
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R002Refbook.Queries.GetR002ByCode
{
    public class GetR002ByCodeQuery : IRequest<R002[]>
    {
        public int Code { get; set; }
    }
}
