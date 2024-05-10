using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetRelevantF007ByCode;

public class GetRelevantF007ByCodeQuery : IRequest<F007>
{
    public int Code { get; set; }
    public DateTime Date { get; set; }
}