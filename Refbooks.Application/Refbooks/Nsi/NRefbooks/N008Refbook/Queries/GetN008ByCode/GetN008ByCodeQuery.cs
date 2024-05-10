
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N008Refbook.Queries.GetN008ByCode
{
    public class GetN008ByCodeQuery : IRequest<N008[]>
    {
        public int Code { get; set; }
    }
}
