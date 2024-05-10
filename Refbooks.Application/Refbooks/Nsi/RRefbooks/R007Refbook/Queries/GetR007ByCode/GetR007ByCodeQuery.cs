
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R007Refbook.Queries.GetR007ByCode
{
    public class GetR007ByCodeQuery : IRequest<R007[]>
    {
        public int Code { get; set; }
    }
}
