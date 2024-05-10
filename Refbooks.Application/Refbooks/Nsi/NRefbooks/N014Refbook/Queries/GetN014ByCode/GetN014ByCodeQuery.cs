
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetN014ByCode
{
    public class GetN014ByCodeQuery : IRequest<N014[]>
    {
        public int Code { get; set; }
    }
}
