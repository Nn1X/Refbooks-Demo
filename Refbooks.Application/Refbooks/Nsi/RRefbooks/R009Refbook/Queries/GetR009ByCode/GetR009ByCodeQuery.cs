
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R009Refbook.Queries.GetR009ByCode
{
    public class GetR009ByCodeQuery : IRequest<R009[]>
    {
        public int Code { get; set; }
    }
}
