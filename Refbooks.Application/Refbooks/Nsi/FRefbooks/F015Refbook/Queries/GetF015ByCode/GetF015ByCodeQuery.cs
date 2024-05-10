
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetF015ByCode
{
    public class GetF015ByCodeQuery : IRequest<F015[]>
    {
        public int Code { get; set; }
    }
}
