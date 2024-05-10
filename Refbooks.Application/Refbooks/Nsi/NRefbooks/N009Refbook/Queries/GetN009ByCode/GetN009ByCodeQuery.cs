
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetN009ByCode
{
    public class GetN009ByCodeQuery : IRequest<N009[]>
    {
        public int Code { get; set; }
    }
}
