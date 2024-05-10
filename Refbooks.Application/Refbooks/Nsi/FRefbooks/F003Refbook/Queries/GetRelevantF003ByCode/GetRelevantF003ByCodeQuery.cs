using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetRelevantF003ByCode;

public class GetRelevantF003ByCodeQuery : IRequest<F003>
{
    public string Code { get; set; }
    public DateTime Date { get; set; }
}