using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetF005ByCode
{
    public class GetF005ByCodeQuery : IRequest<F005>
    {
        public int Code { get; set; }
    }
}
