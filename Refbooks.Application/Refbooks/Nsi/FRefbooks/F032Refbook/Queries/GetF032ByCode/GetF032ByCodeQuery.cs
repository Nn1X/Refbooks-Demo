
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F032Refbook.Queries.GetF032ByCode
{
    public class GetF032ByCodeQuery : IRequest<F032[]>
    {
        public string Code { get; set; }
    }
}
