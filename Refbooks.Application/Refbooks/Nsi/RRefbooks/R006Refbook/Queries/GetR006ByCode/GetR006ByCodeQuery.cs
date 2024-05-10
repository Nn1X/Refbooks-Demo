
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R006Refbook.Queries.GetR006ByCode
{
    public class GetR006ByCodeQuery : IRequest<R006[]>
    {
        public int Code { get; set; }
    }
}
