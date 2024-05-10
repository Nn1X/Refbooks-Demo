
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetN006ByCode
{
    public class GetN006ByCodeQuery : IRequest<N006[]>
    {
        public int Code { get; set; }
    }
}
