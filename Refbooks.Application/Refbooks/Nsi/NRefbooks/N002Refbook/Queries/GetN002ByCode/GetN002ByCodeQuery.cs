
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N002Refbook.Queries.GetN002ByCode
{
    public class GetN002ByCodeQuery : IRequest<N002[]>
    {
        public int Code { get; set; }
    }
}
