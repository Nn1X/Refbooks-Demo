using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F001Refbook.Queries.GetF001ByCode
{
    public class GetF001ByCodeQuery : IRequest<F001>
    {
        public string Code { get; set; }
    }
}
