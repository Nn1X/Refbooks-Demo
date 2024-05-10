
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetN005ByCode
{
    public class GetN005ByCodeQuery : IRequest<N005[]>
    {
        public int Code { get; set; }
    }
}
