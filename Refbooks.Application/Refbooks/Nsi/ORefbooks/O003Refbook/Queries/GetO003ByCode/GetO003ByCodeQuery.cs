
using MediatR;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O003Refbook.Queries.GetO003ByCode
{
    public class GetO003ByCodeQuery : IRequest<O003>
    {
        public string SectionCode { get; set; }
        public string? PositionCode { get; set; }
    }
}
