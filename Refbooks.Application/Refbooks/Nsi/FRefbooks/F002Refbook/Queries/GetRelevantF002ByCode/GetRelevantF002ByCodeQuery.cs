using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetRelevantF002ByCode;

public class GetRelevantF002ByCodeQuery : IRequest<F002>
{
    public string Code { get; set; }
    public DateTime Date { get; set; }
}