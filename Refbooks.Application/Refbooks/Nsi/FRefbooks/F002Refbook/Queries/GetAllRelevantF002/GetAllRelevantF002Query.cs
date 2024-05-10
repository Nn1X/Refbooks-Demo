using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetAllRelevantF002;

public class GetAllRelevantF002Query : IRequest<F002[]>
{
    public DateTime Date { get; set; }
}