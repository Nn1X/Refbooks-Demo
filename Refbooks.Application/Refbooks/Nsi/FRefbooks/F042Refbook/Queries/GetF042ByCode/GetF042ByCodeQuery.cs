
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F042Refbook.Queries.GetF042ByCode
{
    public class GetF042ByCodeQuery : IRequest<F042[]>
    {
        public string Code { get; set; }
    }
}
