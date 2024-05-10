using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetF008ByCode
{
    public class GetF008ByCodeQuery : IRequest<F008[]>
    {
        public int Code { get; set; }
    }
}
