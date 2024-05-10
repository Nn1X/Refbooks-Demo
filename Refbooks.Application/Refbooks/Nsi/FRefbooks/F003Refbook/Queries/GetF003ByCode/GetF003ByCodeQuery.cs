using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetF003ByCode;

public class GetF003ByCodeQuery : IRequest<F003>
{
    public string Code { get; set; }
}