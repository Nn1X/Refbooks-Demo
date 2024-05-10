
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F032Refbook.Queries.GetAllRelevantF032
{
    public class GetAllRelevantF032Query : IRequest<F032[]>
    {
        public DateTime Date { get; set; }
    }
}
