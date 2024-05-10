
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N010Refbook.Queries.GetN010ByCode
{
    public class GetN010ByCodeQuery : IRequest<N010[]>
    {
        public int Code { get; set; }
    }
}
