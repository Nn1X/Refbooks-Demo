
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetN012ByCode
{
    public class GetN012ByCodeQuery : IRequest<N012[]>
    {
        public int Code { get; set; }
    }
}
