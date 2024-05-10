
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N001Refbook.Queries.GetN001ByCode
{
    public class GetN001ByCodeQuery : IRequest<N001[]>
    {
        public int Code { get; set; }
    }
}
