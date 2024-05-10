
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R005Refbook.Queries.GetR005ByCode
{
    public class GetR005ByCodeQuery : IRequest<R005[]>
    {
        public int Code { get; set; }
    }
}
