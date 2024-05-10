
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N007Refbook.Queries.GetN007ByCode
{
    public class GetN007ByCodeQuery : IRequest<N007[]>
    {
        public int Code { get; set; }
    }
}
