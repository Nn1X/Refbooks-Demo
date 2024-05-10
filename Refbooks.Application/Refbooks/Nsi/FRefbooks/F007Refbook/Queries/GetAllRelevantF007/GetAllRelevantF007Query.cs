using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetAllRelevantF007;

public class GetAllRelevantF007Query : IRequest<F007[]>
{
    public DateTime Date { get; set; }
}