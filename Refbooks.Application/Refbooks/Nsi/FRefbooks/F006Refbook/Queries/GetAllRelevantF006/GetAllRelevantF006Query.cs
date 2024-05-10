using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetAllRelevantF006;

public class GetAllRelevantF006Query : IRequest<F006[]>
{
    public DateTime Date { get; set; }
}