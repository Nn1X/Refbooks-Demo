
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetR003ByCode
{
    public class GetR003ByCodeQuery : IRequest<R003[]>
    {
        public int Code { get; set; }
    }
}
