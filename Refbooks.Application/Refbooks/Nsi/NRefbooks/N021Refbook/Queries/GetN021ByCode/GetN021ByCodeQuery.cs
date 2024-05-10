
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetN021ByCode
{
    public class GetN021ByCodeQuery : IRequest<N021[]>
    {
        public int Code { get; set; }
    }
}
