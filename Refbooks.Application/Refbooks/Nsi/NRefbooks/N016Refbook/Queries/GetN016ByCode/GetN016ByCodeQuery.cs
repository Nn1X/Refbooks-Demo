
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetN016ByCode
{
    public class GetN016ByCodeQuery : IRequest<N016[]>
    {
        public int Code { get; set; }
    }
}
