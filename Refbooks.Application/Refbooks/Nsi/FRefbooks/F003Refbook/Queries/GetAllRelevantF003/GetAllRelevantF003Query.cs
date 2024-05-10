using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetAllRelevantF003;

public class GetAllRelevantF003Query : IRequest<F003[]>
{
    public DateTime Date { get; set; }
}