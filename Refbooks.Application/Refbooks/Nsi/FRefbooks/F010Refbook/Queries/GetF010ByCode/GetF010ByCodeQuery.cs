using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetF010ByCode
{
    public class GetF010ByCodeQuery : IRequest<F010[]>
    {
        public string Code { get; set; }
    }
}
