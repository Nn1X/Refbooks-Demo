
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetN004ByCode
{
    public class GetN004ByCodeQuery : IRequest<N004[]>
    {
        public int Code { get; set; }
    }
}
