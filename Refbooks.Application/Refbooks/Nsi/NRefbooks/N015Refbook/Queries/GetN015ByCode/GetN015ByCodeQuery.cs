
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N015Refbook.Queries.GetN015ByCode
{
    public class GetN015ByCodeQuery : IRequest<N015[]>
    {
        public int Code { get; set; }
    }
}
