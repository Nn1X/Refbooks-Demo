using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetRelevantF006ByCode;

public class GetRelevantF006ByCodeQuery : IRequest<F006>
{
    public int Code { get; set; }
    public DateTime Date { get; set; }
}