
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N019Refbook.Queries.GetN019ByCode
{
    public class GetN019ByCodeQuery : IRequest<N019[]>
    {
        public int Code { get; set; }
    }
}
