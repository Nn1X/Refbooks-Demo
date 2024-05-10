using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F009Refbook.Queries.GetF009ByCode
{
    public class GetF009ByCodeQuery : IRequest<F009>
    {
        public int Code { get; set; }
    }
}
