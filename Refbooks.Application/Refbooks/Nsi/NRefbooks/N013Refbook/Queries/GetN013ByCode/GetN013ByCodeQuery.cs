
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetN013ByCode
{
    public class GetN013ByCodeQuery : IRequest<N013[]>
    {
        public int Code { get; set; }
    }
}
