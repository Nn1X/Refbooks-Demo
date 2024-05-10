
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N018Refbook.Queries.GetN018ByCode
{
    public class GetN018ByCodeQuery : IRequest<N018[]>
    {
        public int Code { get; set; }
    }
}
