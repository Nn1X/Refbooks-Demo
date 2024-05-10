
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetN017ByCode
{
    public class GetN017ByCodeQuery : IRequest<N017[]>
    {
        public int Code { get; set; }
    }
}
