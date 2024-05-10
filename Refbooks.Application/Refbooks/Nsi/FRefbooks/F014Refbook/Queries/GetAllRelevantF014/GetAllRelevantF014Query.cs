using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetAllRelevantF014
{
    public class GetAllRelevantF014Query : IRequest<F014[]>
    {
        public DateTime Date { get; set; }
    }
}
