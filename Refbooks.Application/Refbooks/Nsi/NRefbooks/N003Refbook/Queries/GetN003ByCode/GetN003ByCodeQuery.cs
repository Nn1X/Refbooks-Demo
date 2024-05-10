
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N003Refbook.Queries.GetN003ByCode
{
    public class GetN003ByCodeQuery : IRequest<N003[]>
    {
        public int Code { get; set; }
    }
}
