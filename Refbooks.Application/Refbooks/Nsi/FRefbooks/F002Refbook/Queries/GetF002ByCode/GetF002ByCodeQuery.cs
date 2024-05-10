using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetF002ByCode;

public class GetF002ByCodeQuery : IRequest<F002>
{
    public string Code { get; set; }
}