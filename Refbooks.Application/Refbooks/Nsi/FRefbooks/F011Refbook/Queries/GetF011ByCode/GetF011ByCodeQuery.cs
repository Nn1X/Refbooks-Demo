using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F011Refbook.Queries.GetF011ByCode
{
    public class GetF011ByCodeQuery : IRequest<F011>
    {
        public int Code { get; set; }
    }
}
