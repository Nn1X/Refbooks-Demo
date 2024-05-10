using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetF014ByCode
{
    public class GetF014ByCodeQuery : IRequest<F014[]>
    {
        public int Code { get; set; }
    }
}
