
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetN011ByCode
{
    public class GetN011ByCodeQuery : IRequest<N011[]>
    {
        public int Code { get; set; }
    }
}
