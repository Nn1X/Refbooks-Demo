
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetN020ByCode
{
    public class GetN020ByCodeQuery : IRequest<N020[]>
    {
        public string Code { get; set; }
    }
}
