
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R008Refbook.Queries.GetR008ByCode
{
    public class GetR008ByCodeQuery : IRequest<R008[]>
    {
        public int Code { get; set; }
    }
}
